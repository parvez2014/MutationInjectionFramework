
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
// System.Reflection.Emit/CustomAttributeBuilder.cs
//
// Author:
//   Paolo Molaro (lupus@ximian.com)
//
// (C) 2001 Ximian, Inc.  http://www.ximian.com
//

using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
[ComVisible (true)]
[ComDefaultInterface (typeof (_CustomAttributeBuilder))]
[ClassInterface (ClassInterfaceType.None)]
public class CustomAttributeBuilder : _CustomAttributeBuilder
{
    ConstructorInfo ctor;
    byte[] data;

    internal ConstructorInfo Ctor
    {
        get
        {
            return ctor;
        }
    }

    internal byte[] Data
    {
        get
        {
            return data;
        }
    }

    [MethodImplAttribute(MethodImplOptions.InternalCall)]
    static extern byte[] GetBlob(Assembly asmb, ConstructorInfo con, object[] constructorArgs, PropertyInfo[] namedProperties, object[] propertyValues, FieldInfo[] namedFields, object[] fieldValues);

    internal CustomAttributeBuilder( ConstructorInfo con, byte[] cdata)
    {
        ctor = con;
        data = (byte[])cdata.Clone ();
        /* should we check that the user supplied data is correct? */
    }

    public CustomAttributeBuilder( ConstructorInfo con, object[] constructorArgs)
    {
        Initialize (con, constructorArgs, new PropertyInfo [0], new object [0],
                    new FieldInfo [0], new object [0]);
    }
    public CustomAttributeBuilder( ConstructorInfo con, object[] constructorArgs,
                                   FieldInfo[] namedFields, object[] fieldValues)
    {
        Initialize (con, constructorArgs, new PropertyInfo [0], new object [0],
                    namedFields, fieldValues);
    }
    public CustomAttributeBuilder( ConstructorInfo con, object[] constructorArgs,
                                   PropertyInfo[] namedProperties, object[] propertyValues)
    {
        Initialize (con, constructorArgs, namedProperties, propertyValues, new FieldInfo [0],
                    new object [0]);
    }
    public CustomAttributeBuilder( ConstructorInfo con, object[] constructorArgs,
                                   PropertyInfo[] namedProperties, object[] propertyValues,
                                   FieldInfo[] namedFields, object[] fieldValues)
    {
        Initialize (con, constructorArgs, namedProperties, propertyValues, namedFields, fieldValues);
    }

    private bool IsValidType (Type t)
    {
        /* FIXME: Add more checks */
        if (t.IsArray && t.GetArrayRank () > 1)
            return false;
        if (t is TypeBuilder && t.IsEnum)
        {
            // Check that the enum is properly constructed, the unmanaged code
            // depends on this
            Enum.GetUnderlyingType (t);
        }
        if (t.IsClass && !(t.IsArray || t == typeof (object) || t == typeof (Type) || t == typeof (string) || t.Assembly.GetName ().Name == "mscorlib"))
            return false;
        if (t.IsValueType && !(t.IsPrimitive || t.IsEnum || ((t.Assembly is AssemblyBuilder) && t.Assembly.GetName ().Name == "mscorlib")))
            return false;
        return true;
    }

    private bool IsValidParam (object o, Type paramType)
    {
        Type t = o.GetType ();
        if (!IsValidType (t))
            return false;
        if (paramType == typeof (object))
        {
            if (t.IsArray && t.GetArrayRank () == 1)
                return IsValidType (t.GetElementType ());
            if (!t.IsPrimitive && !typeof (Type).IsAssignableFrom (t) && t != typeof (string) && !t.IsEnum)
                return false;
        }
        return true;
    }

    static bool IsValidValue (Type type, object value)
    {
        if (type.IsValueType && value == null)
            return false;
        if (type.IsArray && type.GetElementType ().IsValueType)
        {
            foreach (var v in (Array)value)
            {
                if (v == null)
                    return false;
            }
        }
        return true;
    }

    private void Initialize (ConstructorInfo con, object [] constructorArgs,
                             PropertyInfo [] namedProperties, object [] propertyValues,
                             FieldInfo [] namedFields, object [] fieldValues)
    {
        ctor = con;
        if (con == null)
            throw new ArgumentNullException ("con");
        if (constructorArgs == null)
            throw new ArgumentNullException ("constructorArgs");
        if (namedProperties == null)
            throw new ArgumentNullException ("namedProperties");
        if (propertyValues == null)
            throw new ArgumentNullException ("propertyValues");
        if (namedFields == null)
            throw new ArgumentNullException ("namedFields");
        if (fieldValues == null)
            throw new ArgumentNullException ("fieldValues");
        if (con.GetParameterCount () != constructorArgs.Length)
            throw new ArgumentException ("Parameter count does not match " +
                                         "passed in argument value count.");
        if (namedProperties.Length != propertyValues.Length)
            throw new ArgumentException ("Array lengths must be the same.",
                                         "namedProperties, propertyValues");
        if (namedFields.Length != fieldValues.Length)
            throw new ArgumentException ("Array lengths must be the same.",
                                         "namedFields, fieldValues");
        if ((con.Attributes & MethodAttributes.Static) == MethodAttributes.Static ||
                (con.Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.Private)
            throw new ArgumentException ("Cannot have private or static constructor.");

        Type atype = ctor.DeclaringType;
        int i;
        i = 0;
        foreach (FieldInfo fi in namedFields)
        {
            Type t = fi.DeclaringType;
            if ((atype != t) && (!t.IsSubclassOf (atype)) && (!atype.IsSubclassOf (t)))
                throw new ArgumentException ("Field '" + fi.Name + "' does not belong to the same class as the constructor");
            if (!IsValidType (fi.FieldType))
                throw new ArgumentException ("Field '" + fi.Name + "' does not have a valid type.");
            if (!IsValidValue (fi.FieldType, fieldValues [i]))
                throw new ArgumentException ("Field " + fi.Name + " is not a valid value.");
            // FIXME: Check enums and TypeBuilders as well
            if (fieldValues [i] != null)
                // IsEnum does not seem to work on TypeBuilders
                if (!(fi.FieldType is TypeBuilder) && !fi.FieldType.IsEnum && !fi.FieldType.IsInstanceOfType (fieldValues [i]))
                {
                    //
                    // mcs allways uses object[] for array types and
                    // MS.NET allows this
                    //
                    if (!fi.FieldType.IsArray)
                        throw new ArgumentException ("Value of field '" + fi.Name + "' does not match field type: " + fi.FieldType);
                }
            i ++;
        }

        i = 0;
        foreach (PropertyInfo pi in namedProperties)
        {
            if (!pi.CanWrite)
                throw new ArgumentException ("Property '" + pi.Name + "' does not have a setter.");
            Type t = pi.DeclaringType;
            if ((atype != t) && (!t.IsSubclassOf (atype)) && (!atype.IsSubclassOf (t)))
                throw new ArgumentException ("Property '" + pi.Name + "' does not belong to the same class as the constructor");
            if (!IsValidType (pi.PropertyType))
                throw new ArgumentException ("Property '" + pi.Name + "' does not have a valid type.");
            if (!IsValidValue (pi.PropertyType, propertyValues [i]))
                throw new ArgumentException ("Property " + pi.Name + " is not a valid value.");
            if (propertyValues [i] != null)
            {
                if (!(pi.PropertyType is TypeBuilder) && !pi.PropertyType.IsEnum && !pi.PropertyType.IsInstanceOfType (propertyValues [i]))
                    if (!pi.PropertyType.IsArray)
                        throw new ArgumentException ("Value of property '" + pi.Name + "' does not match property type: " + pi.PropertyType + " -> " + propertyValues [i]);
            }
            i ++;
        }

        i = 0;
        foreach (ParameterInfo pi in GetParameters (con))
        {
            if (pi != null)
            {
                Type paramType = pi.ParameterType;
                if (!IsValidType (paramType))
                    throw new ArgumentException ("Parameter " + i + " does not have a valid type.");
                if (!IsValidValue (paramType, constructorArgs [i]))
                    throw new ArgumentException ("Parameter " + i + " is not a valid value.");

                if (constructorArgs [i] != null)
                {
                    if (!(paramType is TypeBuilder) && !paramType.IsEnum && !paramType.IsInstanceOfType (constructorArgs [i]))
                        if (!paramType.IsArray)
                            throw new ArgumentException ("Value of argument " + i + " does not match parameter type: " + paramType + " -> " + constructorArgs [i]);
                    if (!IsValidParam (constructorArgs [i], paramType))
                        throw new ArgumentException ("Cannot emit a CustomAttribute with argument of type " + constructorArgs [i].GetType () + ".");
                }
            }
            i ++;
        }

        data = GetBlob (atype.Assembly, con, constructorArgs, namedProperties, propertyValues, namedFields, fieldValues);
    }

    /* helper methods */
    internal static int decode_len (byte[] data, int pos, out int rpos)
    {
        int len = 0;
        if ((data [pos] & 0x80) == 0)
        {
            len = (int)(data [pos++] & 0x7f);
        }
        else if ((data [pos] & 0x40) == 0)
        {
            len = ((data [pos] & 0x3f) << 8) + data [pos + 1];
            pos += 2;
        }
        else
        {
            len = ((data [pos] & 0x1f) << 24) + (data [pos + 1] << 16) + (data [pos + 2] << 8) + data [pos + 3];
            pos += 4;
        }
        rpos = pos;
        return len;
    }

    internal static string string_from_bytes (byte[] data, int pos, int len)
    {
        return System.Text.Encoding.UTF8.GetString(data, pos, len);
    }

    internal string string_arg ()
    {
        int pos = 2;
        int len = decode_len (data, pos, out pos);
        return string_from_bytes (data, pos, len);
    }

    internal static UnmanagedMarshal get_umarshal (CustomAttributeBuilder customBuilder, bool is_field)
    {
        byte[] data = customBuilder.Data;
        UnmanagedType subtype = (UnmanagedType)0x50; /* NATIVE_MAX */
        int sizeConst = -1;
        int sizeParamIndex = -1;
        bool hasSize = false;
        int value;
        int utype; /* the (stupid) ctor takes a short or an enum ... */
        string marshalTypeName = null;
        Type marshalTypeRef = null;
        string marshalCookie = String.Empty;
        utype = (int)data [2];
        utype |= ((int)data [3]) << 8;

        string first_type_name = GetParameters (customBuilder.Ctor) [0].ParameterType.FullName;
        int pos = 6;
        if (first_type_name == "System.Int16")
            pos = 4;
        int nnamed = (int)data [pos++];
        nnamed |= ((int)data [pos++]) << 8;

        for (int i = 0; i < nnamed; ++i)
        {
            int paramType; // What is this ?

            /* Skip field/property signature */
            pos ++;
            /* Read type */
            paramType = ((int)data [pos++]);
            if (paramType == 0x55)
            {
                /* enums, the value is preceeded by the type */
                int len2 = decode_len (data, pos, out pos);
                string_from_bytes (data, pos, len2);
                pos += len2;
            }
            int len = decode_len (data, pos, out pos);
            string named_name = string_from_bytes (data, pos, len);
            pos += len;

            switch (named_name)
            {
            case "ArraySubType":
                value = (int)data [pos++];
                value |= ((int)data [pos++]) << 8;
                value |= ((int)data [pos++]) << 16;
                value |= ((int)data [pos++]) << 24;
                subtype = (UnmanagedType)value;
                break;
            case "SizeConst":
                value = (int)data [pos++];
                value |= ((int)data [pos++]) << 8;
                value |= ((int)data [pos++]) << 16;
                value |= ((int)data [pos++]) << 24;
                sizeConst = value;
                hasSize = true;
                break;
            case "SafeArraySubType":
                value = (int)data[pos++];
                value |= ((int)data[pos++]) << 8;
                value |= ((int)data[pos++]) << 16;
                value |= ((int)data[pos++]) << 24;
                subtype = (UnmanagedType)value;
                break;
            case "IidParameterIndex":
                pos += 4;
                break;
            case "SafeArrayUserDefinedSubType":
                len = decode_len (data, pos, out pos);
                string_from_bytes (data, pos, len);
                pos += len;
                break;
            case "SizeParamIndex":
                value = (int)data [pos++];
                value |= ((int)data [pos++]) << 8;
                sizeParamIndex = value;
                hasSize = true;
                break;
            case "MarshalType":
                len = decode_len (data, pos, out pos);
                marshalTypeName = string_from_bytes (data, pos, len);
                pos += len;
                break;
            case "MarshalTypeRef":
                len = decode_len (data, pos, out pos);
                marshalTypeName = string_from_bytes (data, pos, len);
                marshalTypeRef = Type.GetType (marshalTypeName);
                pos += len;
                break;
            case "MarshalCookie":
                len = decode_len (data, pos, out pos);
                marshalCookie = string_from_bytes (data, pos, len);
                pos += len;
                break;
            default:
                throw new Exception ("Unknown MarshalAsAttribute field: " + named_name);
            }
        }

        switch ((UnmanagedType)utype)
        {
        case UnmanagedType.LPArray:
            if (hasSize)
                return UnmanagedMarshal.DefineLPArrayInternal (subtype, sizeConst, sizeParamIndex);
            else
                return UnmanagedMarshal.DefineLPArray (subtype);
        case UnmanagedType.SafeArray:
            return UnmanagedMarshal.DefineSafeArray (subtype);
        case UnmanagedType.ByValArray:
            if (!is_field)
                throw new ArgumentException ("Specified unmanaged type is only valid on fields");

            return UnmanagedMarshal.DefineByValArray (sizeConst);
        case UnmanagedType.ByValTStr:
            return UnmanagedMarshal.DefineByValTStr (sizeConst);
        case UnmanagedType.CustomMarshaler:
            return UnmanagedMarshal.DefineCustom (marshalTypeRef, marshalCookie, marshalTypeName, Guid.Empty);
        default:
            return UnmanagedMarshal.DefineUnmanagedMarshal ((UnmanagedType)utype);
        }
    }

    static Type elementTypeToType (int elementType)
    {
        /* Partition II, section 23.1.16 */
        switch (elementType)
        {
        case 0x02:
            return typeof (bool);
        case 0x03:
            return typeof (char);
        case 0x04:
            return typeof (sbyte);
        case 0x05:
            return typeof (byte);
        case 0x06:
            return typeof (short);
        case 0x07:
            return typeof (ushort);
        case 0x08:
            return typeof (int);
        case 0x09:
            return typeof (uint);
        case 0x0a:
            return typeof (long);
        case 0x0b:
            return typeof (ulong);
        case 0x0c:
            return typeof (float);
        case 0x0d:
            return typeof (double);
        case 0x0e:
            return typeof (string);
        default:
            throw new Exception ("Unknown element type '" + elementType + "'");
        }
    }

    static object decode_cattr_value (Type t, byte[] data, int pos, out int rpos)
    {
        switch (Type.GetTypeCode (t))
        {
        case TypeCode.String:
            if (data [pos] == 0xff)
            {
                rpos = pos + 1;
                return null;
            }
            int len = decode_len (data, pos, out pos);
            rpos = pos + len;
            return string_from_bytes (data, pos, len);
        case TypeCode.Int32:
            rpos = pos + 4;
            return data [pos] + (data [pos + 1] << 8) + (data [pos + 2] << 16) + (data [pos + 3] << 24);
        case TypeCode.Boolean:
            rpos = pos + 1;
            return (data [pos] == 0) ? false : true;
        case TypeCode.Object:
            int subtype = data [pos];
            pos += 1;

            if (subtype >= 0x02 && subtype <= 0x0e)
                return decode_cattr_value (elementTypeToType (subtype), data, pos, out rpos);
            else
                throw new Exception ("Subtype '" + subtype + "' of type object not yet handled in decode_cattr_value");
        default:
            throw new Exception ("FIXME: Type " + t + " not yet handled in decode_cattr_value.");
        }
    }

    internal struct CustomAttributeInfo
    {
        public ConstructorInfo ctor;
        public object[] ctorArgs;
        public string[] namedParamNames;
        public object[] namedParamValues;
    }

    internal static CustomAttributeInfo decode_cattr (CustomAttributeBuilder customBuilder)
    {
        byte[] data = customBuilder.Data;
        ConstructorInfo ctor = customBuilder.Ctor;
        int pos = 0;

        CustomAttributeInfo info = new CustomAttributeInfo ();

        // Prolog
        if (data.Length < 2)
            throw new Exception ("Custom attr length is only '" + data.Length + "'");
        if ((data [0] != 0x1) || (data [1] != 0x00))
            throw new Exception ("Prolog invalid");
        pos = 2;

        ParameterInfo [] pi = GetParameters (ctor);
        info.ctor = ctor;
        info.ctorArgs = new object [pi.Length];
        for (int i = 0; i < pi.Length; ++i)
            info.ctorArgs [i] = decode_cattr_value (pi [i].ParameterType, data, pos, out pos);

        int num_named = data [pos] + (data [pos + 1] * 256);
        pos += 2;

        info.namedParamNames = new string [num_named];
        info.namedParamValues = new object [num_named];
        for (int i = 0; i < num_named; ++i)
        {
            int named_type = data [pos++];
            int data_type = data [pos++];
            string enum_type_name = null;

            if (data_type == 0x55)
            {
                int len2 = decode_len (data, pos, out pos);
                enum_type_name = string_from_bytes (data, pos, len2);
                pos += len2;
            }

            int len = decode_len (data, pos, out pos);
            string name = string_from_bytes (data, pos, len);
            info.namedParamNames [i] = name;
            pos += len;

            if (named_type == 0x53)
            {
                /* Field */
                FieldInfo fi = ctor.DeclaringType.GetField (name, BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.Instance);
                if (fi == null)
                    throw new Exception ("Custom attribute type '" + ctor.DeclaringType + "' doesn't contain a field named '" + name + "'");

                object val = decode_cattr_value (fi.FieldType, data, pos, out pos);
                if (enum_type_name != null)
                {
                    Type enumType = Type.GetType (enum_type_name);
                    val = Enum.ToObject (enumType, val);
                }

                info.namedParamValues [i] = val;
            }
            else
                // FIXME:
                throw new Exception ("Unknown named type: " + named_type);
        }

        return info;
    }

    void _CustomAttributeBuilder.GetIDsOfNames ([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
    {
        throw new NotImplementedException ();
    }

    void _CustomAttributeBuilder.GetTypeInfo (uint iTInfo, uint lcid, IntPtr ppTInfo)
    {
        throw new NotImplementedException ();
    }

    void _CustomAttributeBuilder.GetTypeInfoCount (out uint pcTInfo)
    {
        throw new NotImplementedException ();
    }

    void _CustomAttributeBuilder.Invoke (uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
    {
        throw new NotImplementedException ();
    }

    static ParameterInfo [] GetParameters (ConstructorInfo ctor)
    {
        ConstructorBuilder cb = ctor as ConstructorBuilder;
        if (cb != null)
            return cb.GetParametersInternal ();
        return ctor.GetParameters ();
    }
}
}
