using System;
using System.Collections.Generic;
using System.IO;

namespace LiteCopy
{
	class IgnoreManager
	{
		List<IgnoreBase> m_ignores = new List<IgnoreBase>();

		public void Create(bool visualStudio, bool nodeJS, bool git)
		{
			m_ignores.Clear();
			if (visualStudio)
			{
				m_ignores.Add(new IgnoreVisualStudio());
			}

			if (nodeJS)
			{
				m_ignores.Add(new IgnoreNodeJS());
			}

			if (git)
			{
				m_ignores.Add(new IgnoreGit());
			}
		}

		public bool IsIgored(DirectoryInfo di)
		{
			foreach (IgnoreBase ignore in m_ignores)
			{
				if (ignore.IsIgored(di))
				{
					return true;
				}
			}

			return false;
		}

		public bool IsIgored(FileInfo fi)
		{
			foreach (IgnoreBase ignore in m_ignores)
			{
				if (ignore.IsIgored(fi))
				{
					return true;
				}
			}

			return false;
		}
	}
}
