namespace Eternal
{
	// Token: 0x02000002 RID: 2
	public partial class Discord : global::System.Windows.Forms.Form
	{
		// Token: 0x06000007 RID: 7 RVA: 0x0000211C File Offset: 0x0000031C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002154 File Offset: 0x00000354
		private void InitializeComponent()
		{
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
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
			this.panel1.Size = new global::System.Drawing.Size(299, 33);
			this.panel1.TabIndex = 0;
			this.panel1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.linkLabel1.LinkColor = global::System.Drawing.Color.White;
			this.linkLabel1.Location = new global::System.Drawing.Point(4, 78);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new global::System.Drawing.Size(295, 24);
			this.linkLabel1.TabIndex = 1;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "https://discord.gg/ZADfSsx5ZR";
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.button1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button1.ForeColor = global::System.Drawing.Color.Transparent;
			this.button1.Location = new global::System.Drawing.Point(208, 3);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(41, 26);
			this.button1.TabIndex = 7;
			this.button1.Text = "-";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.button2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button2.ForeColor = global::System.Drawing.Color.Transparent;
			this.button2.Location = new global::System.Drawing.Point(255, 3);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(41, 26);
			this.button2.TabIndex = 8;
			this.button2.Text = "X";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button3.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.button3.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button3.ForeColor = global::System.Drawing.Color.Transparent;
			this.button3.Location = new global::System.Drawing.Point(12, 3);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(41, 26);
			this.button3.TabIndex = 9;
			this.button3.Text = "Back";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			base.ClientSize = new global::System.Drawing.Size(299, 155);
			base.Controls.Add(this.linkLabel1);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Discord";
			this.Text = "Discord";
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000002 RID: 2
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Button button2;
	}
}
