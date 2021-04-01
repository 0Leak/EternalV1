using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace Eternal
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : Form
	{
		// Token: 0x06000009 RID: 9 RVA: 0x000025EF File Offset: 0x000007EF
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002607 File Offset: 0x00000807
		private void Form1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000260A File Offset: 0x0000080A
		private void button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002610 File Offset: 0x00000810
		private void button4_Click(object sender, EventArgs e)
		{
			WebClient wc = new WebClient();
			string nothing = "";
			string ABC2839572358851 = wc.DownloadString("https://pastebin.com/raw/39s1Y8EM");
			bool flag = ABC2839572358851.Contains(this.textBox1.Text);
			if (flag)
			{
				MessageBox.Show("Correct!");
				MainForm open = new MainForm();
				base.Hide();
				open.Show();
			}
			else
			{
				bool flag2 = this.textBox1.Text == nothing;
				if (flag2)
				{
					MessageBox.Show("Enter The Key");
				}
				else
				{
					MessageBox.Show("Wrong Key!");
				}
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000026A3 File Offset: 0x000008A3
		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000026AC File Offset: 0x000008AC
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000026AF File Offset: 0x000008AF
		private void button1_Click_1(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000026BA File Offset: 0x000008BA
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000026D4 File Offset: 0x000008D4
		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002735 File Offset: 0x00000935
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002738 File Offset: 0x00000938
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000279C File Offset: 0x0000099C
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000027FD File Offset: 0x000009FD
		private void x(object sender, EventArgs e)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002800 File Offset: 0x00000A00
		private void button3_Click(object sender, EventArgs e)
		{
			bool flag = this.textBox1.Text == "Test" && this.textBox2.Text == "hi";
			if (flag)
			{
				new MainForm().Show();
				base.Hide();
			}
			else
			{
				MessageBox.Show("Wrong");
				this.textBox1.Clear();
				this.textBox2.Clear();
				this.textBox1.Focus();
			}
		}

		// Token: 0x04000008 RID: 8
		private Point lastPoint;

		// Token: 0x04000009 RID: 9
		private object open;
	}
}
