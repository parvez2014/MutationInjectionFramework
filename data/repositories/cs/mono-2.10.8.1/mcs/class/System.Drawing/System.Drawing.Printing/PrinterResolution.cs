//
// System.Drawing.Printing.PrinterResolution.cs
//
// Author:
//   Dennis Hayes (dennish@Raytek.com)
//   Andreas Nahr (ClassDevelopment@A-SoftTech.com)
//
// (C) 2002 Ximian, Inc
// (C) 2003 Andreas Nahr
//

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
using System;

namespace System.Drawing.Printing
{

#if NET_2_0
[Serializable]
#endif
public class PrinterResolution
{
    private PrinterResolutionKind kind = PrinterResolutionKind.Custom;
    private int x;
    private int y;

#if NET_2_0
    public PrinterResolution ()
    {
    }
#else
    private PrinterResolution ()
    {
    }
#endif

    internal PrinterResolution (int x, int y, PrinterResolutionKind kind)
    {
        this.x = x;
        this.y = y;
        this.kind = kind;
    }

    public int X
    {
        get
        {
            return x;
        }
#if NET_2_0
        set
        {
            x = value;
        }
#endif
    }

    public int Y
    {
        get
        {
            return y;
        }
#if NET_2_0
        set
        {
            y = value;
        }
#endif
    }

    public PrinterResolutionKind Kind
    {
        get
        {
            return kind;
        }
#if NET_2_0
        set
        {
            kind = value;
        }
#endif
    }

    public override string ToString ()
    {
        if (kind != PrinterResolutionKind.Custom)
            return "[PrinterResolution " + kind.ToString () +  "]";

        return "[PrinterResolution X=" + x + " Y=" + y + "]";
    }
}
}
