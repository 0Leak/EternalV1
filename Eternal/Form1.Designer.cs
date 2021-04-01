namespace Eternal
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002888 File Offset: 0x00000A88
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000028C0 File Offset: 0x00000AC0
		private void InitializeComponent()
		{
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.button3 = new global::System.Windows.Forms.Button();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.button1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button1.ForeColor = global::System.Drawing.Color.Transparent;
			this.button1.Location = new global::System.Drawing.Point(163, 1);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(41, 26);
			this.button1.TabIndex = 3;
			this.button1.Text = "-";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click_1);
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.button2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button2.ForeColor = global::System.Drawing.Color.Transparent;
			this.button2.Location = new global::System.Drawing.Point(210, 1);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(41, 26);
			this.button2.TabIndex = 4;
			this.button2.Text = "X";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.panel1.BackColor = global::System.Drawing.Color.DarkRed;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(254, 30);
			this.panel1.TabIndex = 8;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.button3.Location = new global::System.Drawing.Point(80, 312);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(86, 31);
			this.button3.TabIndex = 9;
			this.button3.Text = "Log In";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.textBox1.Location = new global::System.Drawing.Point(46, 128);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(158, 21);
			this.textBox1.TabIndex = 10;
			this.textBox2.Location = new global::System.Drawing.Point(46, 206);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(158, 21);
			this.textBox2.TabIndex = 11;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(87, 60);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(79, 26);
			this.label2.TabIndex = 12;
			this.label2.Text = "Eternal";
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.DarkGray;
			this.label1.Location = new global::System.Drawing.Point(90, 106);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(76, 19);
			this.label1.TabIndex = 13;
			this.label1.Text = "Username";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.DarkGray;
			this.label3.Location = new global::System.Drawing.Point(89, 178);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(73, 19);
			this.label3.TabIndex = 14;
			this.label3.Text = "Password";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			base.ClientSize = new global::System.Drawing.Size(254, 374);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.panel1);
			this.Cursor = global::System.Windows.Forms.Cursors.Default;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Form1";
			this.Text = "Whitlisting";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			base.Click += new global::System.EventHandler(this.x);
			base.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			base.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400000A RID: 10
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Button button3;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Label label3;
	}
}
