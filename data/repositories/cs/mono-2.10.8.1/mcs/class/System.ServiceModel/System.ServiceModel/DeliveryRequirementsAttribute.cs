//
// DeliveryRequirementsAttribute.cs
//
// Author:
//	Atsushi Enomoto <atsushi@ximian.com>
//
// Copyright (C) 2006 Novell, Inc.  http://www.novell.com
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
using System.Collections.Generic;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace System.ServiceModel
{
[MonoTODO]
[AttributeUsage (AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = false)]
public sealed class DeliveryRequirementsAttribute : Attribute,
    IContractBehaviorAttribute, IContractBehavior
{
    QueuedDeliveryRequirementsMode queued_delivery_req;
    bool require_ordered;
    Type target_contract;

    public QueuedDeliveryRequirementsMode QueuedDeliveryRequirements
    {
        get
        {
            return queued_delivery_req;
        }
        set
        {
            queued_delivery_req = value;
        }
    }

    public bool RequireOrderedDelivery
    {
        get
        {
            return require_ordered;
        }
        set
        {
            require_ordered = value;
        }
    }

    public Type TargetContract
    {
        get
        {
            return target_contract;
        }
        set
        {
            target_contract = value;
        }
    }

    void IContractBehavior.AddBindingParameters (
        ContractDescription description,
        ServiceEndpoint endpoint,
        BindingParameterCollection parameters)
    {
        throw new NotImplementedException ();
    }

    void IContractBehavior.ApplyClientBehavior (
        ContractDescription description,
        ServiceEndpoint endpoint,
        ClientRuntime proxy)
    {
        throw new NotImplementedException ();
    }

    void IContractBehavior.ApplyDispatchBehavior (
        ContractDescription description,
        ServiceEndpoint endpoint,
        DispatchRuntime dispatch)
    {
        throw new NotImplementedException ();
    }

    void IContractBehavior.Validate (
        ContractDescription description,
        ServiceEndpoint endpoint)
    {
        throw new NotImplementedException ();
    }
}
}
