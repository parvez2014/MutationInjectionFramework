
//
// Copyright (C) 2004 Novell, Inc (http://www.novell.com)
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

//
// System.Reflection.Emit/EventBuilder.cs
//
// Author:
//   Paolo Molaro (lupus@ximian.com)
//
// (C) 2001 Ximian, Inc.  http://www.ximian.com
//

using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
[ComVisible (true)]
[ComDefaultInterface (typeof (_EventBuilder))]
[ClassInterface (ClassInterfaceType.None)]
public sealed class EventBuilder : _EventBuilder
{
#pragma warning disable 169, 414
    internal string name;
    Type type;
    TypeBuilder typeb;
    CustomAttributeBuilder[] cattrs;
    internal MethodBuilder add_method;
    internal MethodBuilder remove_method;
    internal MethodBuilder raise_method;
    internal MethodBuilder[] other_methods;
    internal EventAttributes attrs;
    int table_idx;
#pragma warning restore 169, 414

    internal EventBuilder (TypeBuilder tb, string eventName, EventAttributes eventAttrs, Type eventType)
    {
        name = eventName;
        attrs = eventAttrs;
        type = eventType;
        typeb = tb;
        table_idx = get_next_table_index (this, 0x14, true);
    }

    internal int get_next_table_index (object obj, int table, bool inc)
    {
        return typeb.get_next_table_index (obj, table, inc);
    }

    public void AddOtherMethod( MethodBuilder mdBuilder)
    {
        if (mdBuilder == null)
            throw new ArgumentNullException ("mdBuilder");
        RejectIfCreated ();
        if (other_methods != null)
        {
            MethodBuilder[] newv = new MethodBuilder [other_methods.Length + 1];
            other_methods.CopyTo (newv, 0);
            other_methods = newv;
        }
        else
        {
            other_methods = new MethodBuilder [1];
        }
        other_methods [other_methods.Length - 1] = mdBuilder;
    }

    public EventToken GetEventToken ()
    {
        return new EventToken (0x14000000 | table_idx);
    }
    public void SetAddOnMethod( MethodBuilder mdBuilder)
    {
        if (mdBuilder == null)
            throw new ArgumentNullException ("mdBuilder");
        RejectIfCreated ();
        add_method = mdBuilder;
    }
    public void SetRaiseMethod( MethodBuilder mdBuilder)
    {
        if (mdBuilder == null)
            throw new ArgumentNullException ("mdBuilder");
        RejectIfCreated ();
        raise_method = mdBuilder;
    }
    public void SetRemoveOnMethod( MethodBuilder mdBuilder)
    {
        if (mdBuilder == null)
            throw new ArgumentNullException ("mdBuilder");
        RejectIfCreated ();
        remove_method = mdBuilder;
    }

    public void SetCustomAttribute( CustomAttributeBuilder customBuilder)
    {
        if (customBuilder == null)
            throw new ArgumentNullException ("customBuilder");
        RejectIfCreated ();
        string attrname = customBuilder.Ctor.ReflectedType.FullName;
        if (attrname == "System.Runtime.CompilerServices.SpecialNameAttribute")
        {
            attrs |= EventAttributes.SpecialName;
            return;
        }
        if (cattrs != null)
        {
            CustomAttributeBuilder[] new_array = new CustomAttributeBuilder [cattrs.Length + 1];
            cattrs.CopyTo (new_array, 0);
            new_array [cattrs.Length] = customBuilder;
            cattrs = new_array;
        }
        else
        {
            cattrs = new CustomAttributeBuilder [1];
            cattrs [0] = customBuilder;
        }
    }

    [ComVisible (true)]
    public void SetCustomAttribute( ConstructorInfo con, byte[] binaryAttribute)
    {
        if (con == null)
            throw new ArgumentNullException ("con");
        if (binaryAttribute == null)
            throw new ArgumentNullException ("binaryAttribute");
        SetCustomAttribute (new CustomAttributeBuilder (con, binaryAttribute));
    }

    private void RejectIfCreated ()
    {
        if (typeb.is_created)
            throw new InvalidOperationException ("Type definition of the method is complete.");
    }

    void _EventBuilder.GetIDsOfNames ([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
    {
        throw new NotImplementedException ();
    }

    void _EventBuilder.GetTypeInfo (uint iTInfo, uint lcid, IntPtr ppTInfo)
    {
        throw new NotImplementedException ();
    }

    void _EventBuilder.GetTypeInfoCount (out uint pcTInfo)
    {
        throw new NotImplementedException ();
    }

    void _EventBuilder.Invoke (uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
    {
        throw new NotImplementedException ();
    }
}
}

