using System;
using System.Collections.Generic;

namespace LiteCopy
{
	class IgnoreVisualStudio : IgnoreBase
	{
		protected override List<string> IgnoredFolders => new List<string> { ".vs", "packages", "bin", "debug", "release", "obj" };
		protected override List<string> IgnoredFilePrefixes => new List<string> { ".pdb", ".csproj.user" };
	}
}
