using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using EasyExploits;

namespace Eternal
{
	// Token: 0x02000005 RID: 5
	public partial class MainForm : Form
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00003025 File Offset: 0x00001225
		public MainForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003048 File Offset: 0x00001248
		private void MainForm_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000304C File Offset: 0x0000124C
		private void button1_Click(object sender, EventArgs e)
		{
			Discord open = new Discord();
			base.Hide();
			open.Show();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000306E File Offset: 0x0000126E
		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003077 File Offset: 0x00001277
		private void button1_Click_1(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003082 File Offset: 0x00001282
		private void MainForm_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000309C File Offset: 0x0000129C
		private void MainForm_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000030FD File Offset: 0x000012FD
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003100 File Offset: 0x00001300
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000311C File Offset: 0x0000131C
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003180 File Offset: 0x00001380
		private void button8_Click(object sender, EventArgs e)
		{
			Discord open = new Discord();
			base.Hide();
			open.Show();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000031A4 File Offset: 0x000013A4
		private void button9_Click(object sender, EventArgs e)
		{
			Settings open = new Settings();
			base.Hide();
			open.Show();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000031C8 File Offset: 0x000013C8
		private void button6_Click(object sender, EventArgs e)
		{
			this.module.LaunchExploit();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000031D7 File Offset: 0x000013D7
		private void button10_Click(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.txt");
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.lua");
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003218 File Offset: 0x00001418
		private void button4_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				openFileDialog.Title = "Open";
				this.richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003260 File Offset: 0x00001460
		private void button5_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			bool flag = saveFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				using (Stream s = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter sw = new StreamWriter(s))
					{
						sw.Write(this.richTextBox1.Text);
					}
				}
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000032E4 File Offset: 0x000014E4
		private void button3_Click(object sender, EventArgs e)
		{
			this.module.ExecuteScript(this.richTextBox1.Text);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000032FE File Offset: 0x000014FE
		private void button7_Click(object sender, EventArgs e)
		{
			this.richTextBox1.Text = "";
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003312 File Offset: 0x00001512
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.richTextBox1.Text = File.ReadAllText(string.Format("./Scripts/{0}", this.listBox1.SelectedItem));
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000333B File Offset: 0x0000153B
		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x04000014 RID: 20
		private Module module = new Module();

		// Token: 0x04000015 RID: 21
		private Point lastPoint;
	}
}
