//
// Mono.Messaging.RabbitMQ
//
// Authors:
//	  Michael Barker (mike@middlesoft.co.uk)
//
// (C) 2008 Michael Barker
//

//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Threading;

using Mono.Messaging;

namespace Mono.Messaging.RabbitMQ
{

public class RabbitMQMessagingProvider : IMessagingProvider
{

    private int txCounter = 0;
    private readonly uint localIp;

    public RabbitMQMessagingProvider()
    {
        localIp = GetLocalIP ();
    }

    private static uint GetLocalIP ()
    {
        //IPHostEntry host = Dns.GetHostEntry (Dns.GetHostName ());
        String strHostName = Dns.GetHostName ();
        IPHostEntry ipEntry = Dns.GetHostByName (strHostName);
        foreach (IPAddress ip in ipEntry.AddressList)
        {
            if (AddressFamily.InterNetwork == ip.AddressFamily)
            {
                byte[] addr = ip.GetAddressBytes ();
                uint localIP = 0;
                for (int i = 0; i < 4 && i < addr.Length; i++)
                {
                    localIP += (uint) (addr[i] << 8 * (3 - i));
                }
                return localIP;
            }
        }
        return 0;
    }

    public IMessage CreateMessage ()
    {
        return new MessageBase ();
    }

    public IMessageQueueTransaction CreateMessageQueueTransaction ()
    {
        Interlocked.Increment (ref txCounter);
        string txId = localIp.ToString () + txCounter.ToString ();
        return new RabbitMQMessageQueueTransaction (txId);
    }

    public void DeleteQueue (QueueReference qRef)
    {
        RabbitMQMessageQueue.Delete (qRef);
    }

    private readonly IDictionary queues = new Hashtable ();
    private readonly ReaderWriterLock qLock = new ReaderWriterLock ();
    private const int TIMEOUT = 15000;

    public IMessageQueue[] GetPublicQueues ()
    {
        IMessageQueue[] qs;
        qLock.AcquireReaderLock (TIMEOUT);
        try
        {
            ICollection qCollection = queues.Values;
            qs = new IMessageQueue[qCollection.Count];
            qCollection.CopyTo (qs, 0);
            return qs;
        }
        finally
        {
            qLock.ReleaseReaderLock ();
        }
    }

    public bool Exists (QueueReference qRef)
    {
        qLock.AcquireReaderLock (TIMEOUT);
        try
        {
            return queues.Contains (qRef);
        }
        finally
        {
            qLock.ReleaseReaderLock ();
        }
    }

    public IMessageQueue CreateMessageQueue (QueueReference qRef,
            bool transactional)
    {
        qLock.AcquireWriterLock (TIMEOUT);
        try
        {
            IMessageQueue mq = new RabbitMQMessageQueue (this, qRef,
                    transactional);
            queues[qRef] = mq;
            return mq;
        }
        finally
        {
            qLock.ReleaseWriterLock ();
        }
    }

    public IMessageQueue GetMessageQueue (QueueReference qRef)
    {
        qLock.AcquireReaderLock (TIMEOUT);
        try
        {
            if (queues.Contains (qRef))
                return (IMessageQueue) queues[qRef];
            else
            {
                LockCookie lc = qLock.UpgradeToWriterLock (TIMEOUT);
                try
                {
                    IMessageQueue mq = new RabbitMQMessageQueue (this, qRef,
                            false);
                    queues[qRef] = mq;
                    return mq;
                }
                finally
                {
                    qLock.DowngradeFromWriterLock (ref lc);
                }
            }
        }
        finally
        {
            qLock.ReleaseReaderLock ();
        }
    }


}
}
