//
// FormsIdentityCas.cs - CAS unit tests for System.Web.Security.FormsIdentity
//
// Author:
//	Sebastien Pouliot  <sebastien@ximian.com>
//
// Copyright (C) 2005 Novell, Inc (http://www.novell.com)
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

using NUnit.Framework;

using System;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Web;
using System.Web.Security;

namespace MonoCasTests.System.Web.Security
{

[TestFixture]
[Category ("CAS")]
public class FormsIdentityCas : AspNetHostingMinimal
{

    private FormsAuthenticationTicket ticket;

    [TestFixtureSetUp]
    public void FixtureSetUp ()
    {
        // other (simpler) ctors fails with NRE under 1.x
        ticket = new FormsAuthenticationTicket (3, "mine", DateTime.MinValue, DateTime.Now.AddSeconds (-1), false, "data", "path");
    }

    [Test]
    [PermissionSet (SecurityAction.Deny, Unrestricted = true)]
    public void Identity ()
    {
        FormsIdentity identity = new FormsIdentity (ticket);
        Assert.AreEqual ("Forms", identity.AuthenticationType, "AuthenticationType");
        Assert.IsTrue (identity.IsAuthenticated, "IsAuthenticated");
        Assert.AreEqual ("mine", identity.Name, "Name");
        Assert.IsTrue (Object.ReferenceEquals (ticket, identity.Ticket), "Ticket");
    }

    // LinkDemand

    public override object CreateControl (SecurityAction action, AspNetHostingPermissionLevel level)
    {
        ConstructorInfo ci = this.Type.GetConstructor (new Type[1] { typeof (FormsAuthenticationTicket) });
        Assert.IsNotNull (ci, ".ctor(FormsAuthenticationTicket)");
        return ci.Invoke (new object[1] { ticket });
    }

    public override Type Type
    {
        get
        {
            return typeof (FormsIdentity);
        }
    }
}
}
