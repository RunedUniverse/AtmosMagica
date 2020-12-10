using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Vintagestory.API.Common;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("AtmosMagica")]
[assembly: AssemblyDescription("")]
//[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("RunedUniverse")]
//[assembly: AssemblyProduct("")]
[assembly: AssemblyCopyright("Copyright © 2020 RunedUniverse")]

//[assembly: AssemblyTrademark("")]
//[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("838cd927-28c7-423a-b765-6ede76c36ac5")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
[assembly: AssemblyVersion("1.0.0")]
[assembly: AssemblyFileVersion("1.0.0")]

[assembly: ModInfo( "AtmosMagica", "atmosmagica",
    Version = "1.0.0",
    Description = "To be added",
    Authors = new[] { "[RunedUniverse] Pl4yingNight"},
    RequiredOnClient = true)]

 [assembly: ModDependency("game")]
