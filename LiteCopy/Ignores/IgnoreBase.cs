using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LiteCopy
{
	abstract class IgnoreBase
	{
		protected abstract List<string> IgnoredFolders { get; }
		protected abstract List<string> IgnoredFilePrefixes { get; }		

		public virtual bool IsIgored(DirectoryInfo di)
		{
			if (IgnoredFolders == null)
			{
				return false;
			}

			return IgnoredFolders.IndexOf(di.Name.ToLower()) != -1;
		}

		public virtual bool IsIgored(FileInfo fi)
		{
			if (IgnoredFilePrefixes == null)
			{
				return false;
			}

			string name = fi.Name.ToLower();
			foreach (string surfix in IgnoredFilePrefixes)
			{				
				if (name.Length < surfix.Length)
				{
					continue;
				}

				if (name.Substring(name.Length - surfix.Length).ToLower() == surfix)
				{
					return true;
				}
			}

			return false;
		}
	}
}
