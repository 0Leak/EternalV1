namespace Eternal
{
	// Token: 0x02000005 RID: 5
	public partial class MainForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00003340 File Offset: 0x00001540
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003378 File Offset: 0x00001578
		private void InitializeComponent()
		{
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.button5 = new global::System.Windows.Forms.Button();
			this.button6 = new global::System.Windows.Forms.Button();
			this.button7 = new global::System.Windows.Forms.Button();
			this.button8 = new global::System.Windows.Forms.Button();
			this.button9 = new global::System.Windows.Forms.Button();
			this.button10 = new global::System.Windows.Forms.Button();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.DarkRed;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(812, 40);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(23, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "E";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(356, 7);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(128, 26);
			this.label2.TabIndex = 1;
			this.label2.Text = "Eternal V1.1";
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.button1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button1.ForeColor = global::System.Drawing.Color.Transparent;
			this.button1.Location = new global::System.Drawing.Point(719, 9);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(41, 26);
			this.button1.TabIndex = 5;
			this.button1.Text = "-";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click_1);
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.button2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button2.ForeColor = global::System.Drawing.Color.Transparent;
			this.button2.Location = new global::System.Drawing.Point(766, 9);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(41, 26);
			this.button2.TabIndex = 6;
			this.button2.Text = "X";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button3.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.button3.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button3.ForeColor = global::System.Drawing.Color.Transparent;
			this.button3.Location = new global::System.Drawing.Point(12, 360);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(79, 40);
			this.button3.TabIndex = 7;
			this.button3.Text = "Exacute";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button4.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.button4.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button4.ForeColor = global::System.Drawing.Color.Transparent;
			this.button4.Location = new global::System.Drawing.Point(97, 372);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(67, 28);
			this.button4.TabIndex = 8;
			this.button4.Text = "Load";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.button5.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.button5.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button5.ForeColor = global::System.Drawing.Color.Transparent;
			this.button5.Location = new global::System.Drawing.Point(170, 372);
			this.button5.Name = "button5";
			this.button5.Size = new global::System.Drawing.Size(67, 28);
			this.button5.TabIndex = 9;
			this.button5.Text = "Save";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new global::System.EventHandler(this.button5_Click);
			this.button6.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.button6.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button6.ForeColor = global::System.Drawing.Color.Transparent;
			this.button6.Location = new global::System.Drawing.Point(644, 360);
			this.button6.Name = "button6";
			this.button6.Size = new global::System.Drawing.Size(79, 40);
			this.button6.TabIndex = 11;
			this.button6.Text = "Attach";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new global::System.EventHandler(this.button6_Click);
			this.button7.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.button7.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button7.ForeColor = global::System.Drawing.Color.Transparent;
			this.button7.Location = new global::System.Drawing.Point(243, 372);
			this.button7.Name = "button7";
			this.button7.Size = new global::System.Drawing.Size(67, 28);
			this.button7.TabIndex = 10;
			this.button7.Text = "Clear";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new global::System.EventHandler(this.button7_Click);
			this.button8.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.button8.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button8.ForeColor = global::System.Drawing.Color.Transparent;
			this.button8.Location = new global::System.Drawing.Point(389, 372);
			this.button8.Name = "button8";
			this.button8.Size = new global::System.Drawing.Size(67, 28);
			this.button8.TabIndex = 13;
			this.button8.Text = "Discord";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new global::System.EventHandler(this.button8_Click);
			this.button9.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.button9.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button9.ForeColor = global::System.Drawing.Color.Transparent;
			this.button9.Location = new global::System.Drawing.Point(316, 372);
			this.button9.Name = "button9";
			this.button9.Size = new global::System.Drawing.Size(67, 28);
			this.button9.TabIndex = 12;
			this.button9.Text = "Settings";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new global::System.EventHandler(this.button9_Click);
			this.button10.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.button10.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button10.ForeColor = global::System.Drawing.Color.Transparent;
			this.button10.Location = new global::System.Drawing.Point(726, 360);
			this.button10.Name = "button10";
			this.button10.Size = new global::System.Drawing.Size(79, 40);
			this.button10.TabIndex = 14;
			this.button10.Text = "Refresh";
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += new global::System.EventHandler(this.button10_Click);
			this.richTextBox1.BackColor = global::System.Drawing.Color.Black;
			this.richTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTextBox1.ForeColor = global::System.Drawing.Color.AliceBlue;
			this.richTextBox1.Location = new global::System.Drawing.Point(12, 46);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(683, 303);
			this.richTextBox1.TabIndex = 15;
			this.richTextBox1.Text = "Made By Tibby \n\nDiscord | tibby#2229";
			this.richTextBox1.TextChanged += new global::System.EventHandler(this.richTextBox1_TextChanged);
			this.listBox1.BackColor = global::System.Drawing.Color.Black;
			this.listBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.listBox1.ForeColor = global::System.Drawing.Color.AliceBlue;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new global::System.Drawing.Point(701, 46);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(99, 301);
			this.listBox1.TabIndex = 16;
			this.listBox1.SelectedIndexChanged += new global::System.EventHandler(this.listBox1_SelectedIndexChanged);
			base.AccessibleRole = global::System.Windows.Forms.AccessibleRole.None;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			base.ClientSize = new global::System.Drawing.Size(812, 412);
			base.Controls.Add(this.listBox1);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.button10);
			base.Controls.Add(this.button8);
			base.Controls.Add(this.button9);
			base.Controls.Add(this.button6);
			base.Controls.Add(this.button7);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.panel1);
			this.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.ForeColor = global::System.Drawing.Color.Black;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "MainForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TestExploit";
			base.Load += new global::System.EventHandler(this.MainForm_Load);
			base.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			base.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000016 RID: 22
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Button button3;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Button button4;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Button button5;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Button button6;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Button button7;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Button button8;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Button button9;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Button button10;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.ListBox listBox1;
	}
}
