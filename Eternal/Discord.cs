using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Eternal
{
	// Token: 0x02000002 RID: 2
	public partial class Discord : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Discord()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		private void button3_Click(object sender, EventArgs e)
		{
			MainForm open = new MainForm();
			base.Hide();
			open.Show();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000208C File Offset: 0x0000028C
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020ED File Offset: 0x000002ED
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002107 File Offset: 0x00000307
		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002110 File Offset: 0x00000310
		private void button1_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x04000001 RID: 1
		private Point lastPoint;
	}
}
