// CS3018: `C.field' cannot be marked as CLS-compliant because it is a member of non CLS-compliant type `C'
// Line: 10
// Compiler options: -warnaserror -warn:1

using System;
[assembly:CLSCompliant (false)]

public class C
{
    [CLSCompliant (true)]
    public long field;
}
