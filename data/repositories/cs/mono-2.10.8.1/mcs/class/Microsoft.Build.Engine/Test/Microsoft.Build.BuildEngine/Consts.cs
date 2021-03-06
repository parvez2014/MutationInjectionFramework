//
// Consts.cs
//
// Author:
//   Marek Sieradzki (marek.sieradzki@gmail.com)
//
// (C) 2006 Marek Sieradzki
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

using System;
using System.IO;
using Microsoft.Build.Utilities;

public static class Consts
{

    public static bool RunningOnMono ()
    {
        return Type.GetType ("Mono.Runtime") != null;
    }

    public static string BinPath
    {
        get
        {
            if (RunningOnMono ())
                return "../../tools/xbuild/xbuild";
            else
                return ToolLocationHelper.GetPathToDotNetFramework (TargetDotNetFrameworkVersion.Version20);
        }
    }

    public static string ToolsVersionString
    {
        get
        {
#if NET_4_0
            return " ToolsVersion='4.0'";
#elif NET_3_5
            return " ToolsVersion='3.5'";
#else
            return String.Empty;
#endif
        }
    }

    public static string GetTasksAsmPath ()
    {
#if NET_4_0
        return Path.Combine (ToolLocationHelper.GetPathToDotNetFramework (TargetDotNetFrameworkVersion.Version40), "Microsoft.Build.Tasks.v4.0.dll");
#elif NET_3_5
        return Path.Combine (ToolLocationHelper.GetPathToDotNetFramework (TargetDotNetFrameworkVersion.Version35), "Microsoft.Build.Tasks.v3.5.dll");
#else
        return Path.Combine (ToolLocationHelper.GetPathToDotNetFramework (TargetDotNetFrameworkVersion.Version20), "Microsoft.Build.Tasks.dll");
#endif
    }
}
