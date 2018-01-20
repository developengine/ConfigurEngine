#load nuget:?package=DevelopEngine.Cake&version=0.1.2


///////////////////////////////////////////////////////////////////////////////
// ARGUMENTS
///////////////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

///////////////////////////////////////////////////////////////////////////////
// GLOBAL VARIABLES
///////////////////////////////////////////////////////////////////////////////

var projects = GetProjects(File("./src/ConfigurEngine.sln"), configuration);
var artifacts = "./dist/";
var frameworks = new List<string> { "netstandard2.0" };


///////////////////////////////////////////////////////////////////////////////
// TASKS
///////////////////////////////////////////////////////////////////////////////


Task("Default")
.IsDependentOn("Post-Build")
.IsDependentOn("NuGet");

Task("CI")
.IsDependentOn("Publish");

RunTarget(target);
