﻿using CommandLine;

namespace NuGet2Unity
{
	class Options
	{
		[Option('n', "nugetpackage", Required = true, HelpText = "NuGet package to repackage")]
		public string Package { get; set; }

		[Option('v', "version", HelpText = "Version of NuGet package to use")]
		public string Version { get; set; }

		[Option('p', "unityproject", HelpText = "Path to the Unity project to include with this package")]
		public string UnityProject { get; set; }

		[Option('m', "includemeta", HelpText = "Include .meta files from the Unity project")]
		public bool IncludeMeta { get; set; }

		[Option('o', "outputpath", HelpText = "Path and filename of the .unitypackage")]
		public string OutputPath { get; set; }

		[Option("verbose", HelpText = "Maximum verbosity")]
		public bool Verbose { get; set; }

		[Option(HelpText = "Build for .NET 4.x compatibility")]
		public bool Net46 { get; set; }

		[Option(Default = true, HelpText = "Build for .NET Standard 2.0 compatibility")]
		public bool NetStandard { get; set; }

		[Option("skipwsa", Default = true, HelpText = "Do not add WSA DLLs to package")]
		public bool SkipWsa { get; set; }

		[Option("skipjsonfix", HelpText = "Do not add link.xml to package if Json.NET is used")]
		public bool SkipJsonFix { get; set; }
	}
}
