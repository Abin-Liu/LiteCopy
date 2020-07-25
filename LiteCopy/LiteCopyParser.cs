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
		public List<string> SrcFiles { get; private set; } = new List<string>();
		public List<string> DestFiles { get; private set; } = new List<string>();

		IgnoreManager m_im = null;
		string m_destFolder = null;

		public void Parse(List<string> sourceFolders, string destFolder, IgnoreManager im)
		{
			m_destFolder = destFolder;
			m_im = im;
			Release();
			foreach (string folder in sourceFolders)
			{
				DirectoryInfo source = new DirectoryInfo(folder);
				QueueItems(source, destFolder + "\\" + source.Name);
			}
		}

		public void Release()
		{
			SrcFiles.Clear();
			DestFiles.Clear();
		}

		string GetDestPath(int baseLength, string fullPath)
		{
			return m_destFolder + fullPath.Substring(baseLength);
		}

		void QueueItems(DirectoryInfo source, string dest)
		{
			foreach (FileInfo file in source.GetFiles())
			{
				if (m_im.IsExtIgnored(file.Extension))
				{
					continue;
				}

				SrcFiles.Add(file.FullName);
				DestFiles.Add(dest + "\\" + file.Name);				
			}

			foreach (DirectoryInfo sub in source.GetDirectories())
			{
				if (m_im.IsFolderIgnored(sub.Name))
				{
					continue;
				}

				string destSub = dest + "\\" + sub.Name;
				Directory.CreateDirectory(destSub);
				QueueItems(sub, destSub);
			}
		}		
	}
}
