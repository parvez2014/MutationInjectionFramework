//
// EncoderFallback.cs
//
// Author:
//	Atsushi Enomoto <atsushi@ximian.com>
//

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

namespace System.Text
{
[Serializable]
public abstract class EncoderFallback
{
    static EncoderFallback exception_fallback =
        new EncoderExceptionFallback ();
    static EncoderFallback replacement_fallback =
        new EncoderReplacementFallback ();
    static EncoderFallback standard_safe_fallback =
        new EncoderReplacementFallback ("\uFFFD");

    protected EncoderFallback ()
    {
    }

    public static EncoderFallback ExceptionFallback
    {
        get
        {
            return exception_fallback;
        }
    }

    public abstract int MaxCharCount
    {
        get;
    }

    public static EncoderFallback ReplacementFallback
    {
        get
        {
            return replacement_fallback;
        }
    }

    internal static EncoderFallback StandardSafeFallback
    {
        get
        {
            return standard_safe_fallback;
        }
    }

    public abstract EncoderFallbackBuffer CreateFallbackBuffer ();
}
}
