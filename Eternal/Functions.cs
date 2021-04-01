using System;
using System.IO;
using System.Windows.Forms;

namespace Eternal
{
	// Token: 0x02000004 RID: 4
	internal class Functions
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00002FD4 File Offset: 0x000011D4
		public static void PopulateListBox(ListBox lsb, string Folder, string FileType)
		{
			DirectoryInfo dinfo = new DirectoryInfo(Folder);
			FileInfo[] Files = dinfo.GetFiles(FileType);
			foreach (FileInfo file in Files)
			{
				lsb.Items.Add(file.Name);
			}
		}
	}
}
