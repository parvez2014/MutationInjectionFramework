package org.omg.IOP.CodecPackage;


/**
* org/omg/IOP/CodecPackage/FormatMismatch.java .
* Generated by the IDL-to-Java compiler (portable), version "3.2"
* from ../../../../src/share/classes/org/omg/PortableInterceptor/IOP.idl
* Friday, April 20, 2012 2:12:47 PM UTC
*/

public final class FormatMismatch extends org.omg.CORBA.UserException
{

    public FormatMismatch ()
    {
        super(FormatMismatchHelper.id());
    } // ctor


    public FormatMismatch (String $reason)
    {
        super(FormatMismatchHelper.id() + "  " + $reason);
    } // ctor

} // class FormatMismatch