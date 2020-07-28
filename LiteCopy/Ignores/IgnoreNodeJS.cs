using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LiteCopy
{
	class IgnoreNodeJS : IgnoreBase
	{
		protected override List<string> IgnoredFolders => new List<string> { "node_modules", "dist" };
		protected override List<string> IgnoredFilePrefixes => new List<string> { "package-lock.json", };
	}
}
