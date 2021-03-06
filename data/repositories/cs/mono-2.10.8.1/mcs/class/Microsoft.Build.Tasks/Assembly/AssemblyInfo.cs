//
// AssemblyInfo.cs
//
// Author:
//   Marek Sieradzki (mare.sieradzki@gmail.com
//
// (C) 2005 Marek Sieradzki
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

#if NET_2_0

using System;
using System.Reflection;
using System.Resources;
using System.Security;
using System.Security.Permissions;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about the Microsoft.Build.Tasks assembly

[assembly: AssemblyTitle ("Microsoft.Build.Tasks.dll")]
[assembly: AssemblyDescription ("Microsoft.Build.Tasks.dll")]
[assembly: AssemblyDefaultAlias ("Microsoft.Build.Tasks.dll")]

[assembly: AssemblyCompany (Consts.MonoCompany)]
[assembly: AssemblyProduct (Consts.MonoProduct)]
[assembly: AssemblyCopyright (Consts.MonoCopyright)]
[assembly: AssemblyVersion (Consts.FxVersion)]
[assembly: SatelliteContractVersion (Consts.FxVersion)]
[assembly: AssemblyInformationalVersion (Consts.FxFileVersion)]

[assembly: NeutralResourcesLanguage ("en-US")]

[assembly: ComVisible (false)]
[assembly: Guid ("E3D4D3B9-944C-407b-A82E-B19719EA7FB3")]
[assembly: CLSCompliant (true)]
[assembly: AssemblyDelaySign (true)]
[assembly: AssemblyKeyFile("../msfinal.pub")]

[assembly: AssemblyFileVersion (Consts.FxFileVersion)]
[assembly: CompilationRelaxations (CompilationRelaxations.NoStringInterning)]
[assembly: Debuggable (DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility (WrapNonExceptionThrows = true)]
[assembly: SecurityPermission (SecurityAction.RequestMinimum, Flags = SecurityPermissionFlag.Execution)]
[assembly: SecurityPermission (SecurityAction.RequestMinimum, SkipVerification = true)]

#endif
