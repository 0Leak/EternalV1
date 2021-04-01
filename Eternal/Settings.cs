using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Eternal
{
	// Token: 0x02000007 RID: 7
	public partial class Settings : Form
	{
		// Token: 0x06000032 RID: 50 RVA: 0x000040A5 File Offset: 0x000022A5
		public Settings()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000040BD File Offset: 0x000022BD
		private void button1_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000040C8 File Offset: 0x000022C8
		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000040D4 File Offset: 0x000022D4
		private void button3_Click(object sender, EventArgs e)
		{
			MainForm open = new MainForm();
			base.Hide();
			open.Show();
		}
	}
}
