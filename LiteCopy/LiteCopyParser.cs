using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MFGLib;

namespace LiteCopy
{
	class LiteCopyParser
	{
		public List<string> SrcFiles { get; private set; }
		public List<string> DestFiles { get; private set; }

		Dictionary<string, bool> m_ignoredFolders = null;
		Dictionary<string, bool> m_ignoredFiless = null;		
		string m_destFolder = null;
		int m_sourceFolderLen = 0;

		public void Start(string sourceFolder, string destFolder, string ignoredItems)
		{
			SrcFiles = new List<string>();
			DestFiles = new List<string>();
			m_destFolder = destFolder;
			m_sourceFolderLen = sourceFolder.Length;
			ParseIgnoredItems(ignoredItems);			
			QueueItems(new DirectoryInfo(sourceFolder));
		}

		string GetDestPath(string fullPath)
		{
			return m_destFolder + fullPath.Substring(m_sourceFolderLen);
		}

		void QueueItems(DirectoryInfo dir)
		{
			foreach (FileInfo file in dir.GetFiles())
			{
				string ext = file.Extension.ToLower();
				if (m_ignoredFiless.ContainsKey(ext))
				{
					continue;
				}

				SrcFiles.Add(file.FullName);
				DestFiles.Add(GetDestPath(file.FullName));				
			}

			foreach (DirectoryInfo subdir in dir.GetDirectories())
			{
				if (m_ignoredFolders.ContainsKey(subdir.Name.ToLower()))
				{
					continue;
				}

				Directory.CreateDirectory(GetDestPath(subdir.FullName));
				QueueItems(subdir);
			}
		}

		void ParseIgnoredItems(string ignoredItems)
		{
			m_ignoredFolders = new Dictionary<string, bool>();
			m_ignoredFiless = new Dictionary<string, bool>();

			string[] lines = ignoredItems.Split('\n');
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
						m_ignoredFiless.Add(item.ToLower(), true);
					}
				}
				catch
				{
				}				
			}
		}
	}
}
