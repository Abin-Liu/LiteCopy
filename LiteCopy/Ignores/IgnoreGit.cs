using System;
using System.Collections.Generic;

namespace LiteCopy
{
	class IgnoreGit : IgnoreBase
	{
		protected override List<string> IgnoredFolders => new List<string> { ".git", };
		protected override List<string> IgnoredFilePrefixes => new List<string> { ".gitattributes", ".gitignore" };		
	}
}
