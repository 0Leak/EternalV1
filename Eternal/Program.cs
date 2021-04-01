using System;
using System.Windows.Forms;

namespace Eternal
{
	// Token: 0x02000006 RID: 6
	internal static class Program
	{
		// Token: 0x06000031 RID: 49 RVA: 0x0000408A File Offset: 0x0000228A
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
