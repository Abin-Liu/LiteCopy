using System;
using System.Collections.Generic;
using System.IO;

namespace LiteCopy
{
	class IgnoreManager
	{
		public string Text { get; set; }

		public const string DefaultText = ".vs/\r\nbin/\r\ndebug/\r\nrelease/\r\npackages/\r\nobj/\r\nnode_modules/\r\n#.git/\r\n#.gitattributes\r\n#.gitignore";

		static readonly string IgnoresFile = AppDomain.CurrentDomain.BaseDirectory + "Ignores.txt";
		Dictionary<string, bool> m_ignoredFolders = new Dictionary<string, bool>();
		Dictionary<string, bool> m_ignoredExts = new Dictionary<string, bool>();
		
		public void Load()
		{
			try
			{
				Text = File.ReadAllText(IgnoresFile);
			}
			catch
			{
				Text = DefaultText;
			}
		}

		public void Save()
		{
			File.WriteAllText(IgnoresFile, Text);
		}		

		public void Parse()
		{
			m_ignoredFolders.Clear();
			m_ignoredExts.Clear();

			if (string.IsNullOrEmpty(Text))
			{
				return;
			}

			string[] lines = Text.Split('\n');
			foreach (string line in lines)
			{
				string item;
				int pos = line.IndexOf('#');
				if (pos == -1)
				{
					item = line;
				}
				else
				{
					item = line.Substring(0, pos);
				}

				item = item.Trim();
				if (item == "")
				{
					continue;
				}

				try
				{
					char ch = item[item.Length - 1];
					if (ch == '/' || ch == '\\')
					{
						m_ignoredFolders.Add(item.Substring(0, item.Length - 1).ToLower(), true);
					}
					else
					{
						m_ignoredExts.Add(item.ToLower(), true);
					}
				}
				catch
				{
				}
			}
		}

		public bool IsFolderIgnored(string name)
		{
			if (name == null)
			{
				return true;
			}

			return m_ignoredFolders.ContainsKey(name.ToLower());
		}

		public bool IsExtIgnored(string ext)
		{
			if (ext == null)
			{
				return true;
			}

			return m_ignoredExts.ContainsKey(ext.ToLower());
		}
	}
}
