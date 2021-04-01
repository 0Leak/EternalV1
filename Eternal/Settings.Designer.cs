namespace Eternal
{
	// Token: 0x02000007 RID: 7
	public partial class Settings : global::System.Windows.Forms.Form
	{
		// Token: 0x06000036 RID: 54 RVA: 0x000040F8 File Offset: 0x000022F8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004130 File Offset: 0x00002330
		private void InitializeComponent()
		{
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.DarkRed;
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(426, 33);
			this.panel1.TabIndex = 0;
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.button1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button1.ForeColor = global::System.Drawing.Color.Transparent;
			this.button1.Location = new global::System.Drawing.Point(334, 3);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(41, 26);
			this.button1.TabIndex = 7;
			this.button1.Text = "-";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.button2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button2.ForeColor = global::System.Drawing.Color.Transparent;
			this.button2.Location = new global::System.Drawing.Point(381, 3);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(41, 26);
			this.button2.TabIndex = 8;
			this.button2.Text = "X";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button3.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.button3.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button3.ForeColor = global::System.Drawing.Color.Transparent;
			this.button3.Location = new global::System.Drawing.Point(12, 4);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(41, 26);
			this.button3.TabIndex = 9;
			this.button3.Text = "-";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			base.ClientSize = new global::System.Drawing.Size(426, 207);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Settings";
			this.Text = "Settings";
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000026 RID: 38
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Button button3;
	}
}
