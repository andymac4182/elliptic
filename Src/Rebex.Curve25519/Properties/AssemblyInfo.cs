﻿#if NETCF_1_0
using System;
[assembly: CLSCompliant(true)]
#endif

#if ANDROID || IOS
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("Rebex.Curve25519")]
[assembly: AssemblyProduct("Rebex.Curve25519")]
[assembly: AssemblyCopyright("Copyright © Rebex.NET 2017")]
[assembly: ComVisible(false)]

[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
#endif

#if IOS
// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("319b596f-86fd-4ee7-9852-f52bc228c1c0")]
#endif