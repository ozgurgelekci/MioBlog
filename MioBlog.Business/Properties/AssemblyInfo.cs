using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MioBlog.Core.Aspects.Postsharp.ExcepitonAspects;
using MioBlog.Core.Aspects.Postsharp.LogAspects;
using MioBlog.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("MioBlog.Business")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Microsoft")]
[assembly: AssemblyProduct("MioBlog.Business")]
[assembly: AssemblyCopyright("Copyright © Microsoft 2018")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

//Info Logger
//[assembly:LogAspect(typeof(FileLogger),AttributeTargetTypes = "MioBlog.Business.Concretes.Managers.*")]
//[assembly: LogAspect(typeof(DatabaseLogger), AttributeTargetTypes = "MioBlog.Business.Concretes.Managers.*")]

// ExceptionLogAspect
//[assembly: ExceptionLogAspect(typeof(DatabaseLogger), AttributeTargetTypes = "MioBlog.Business.Concretes.Managers.*")]
//[assembly: ExceptionLogAspect(typeof(FileLogger), AttributeTargetTypes = "MioBlog.Business.Concretes.Managers.*")]


// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("a7fec013-137d-4ed2-9374-0361ab3b4779")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
