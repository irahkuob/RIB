namespace RIB
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CCP = new System.Windows.Forms.TabPage();
            this.copy = new System.Windows.Forms.Button();
            this.all_txt = new System.Windows.Forms.TextBox();
            this.rip_txt = new System.Windows.Forms.TextBox();
            this.cle_txt = new System.Windows.Forms.TextBox();
            this.cpt_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BANQUE = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.CCP.SuspendLayout();
            this.BANQUE.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CCP);
            this.tabControl1.Controls.Add(this.BANQUE);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(413, 254);
            this.tabControl1.TabIndex = 0;
            // 
            // CCP
            // 
            this.CCP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(171)))), ((int)(((byte)(128)))));
            this.CCP.Controls.Add(this.copy);
            this.CCP.Controls.Add(this.all_txt);
            this.CCP.Controls.Add(this.rip_txt);
            this.CCP.Controls.Add(this.cle_txt);
            this.CCP.Controls.Add(this.cpt_txt);
            this.CCP.Controls.Add(this.label4);
            this.CCP.Controls.Add(this.label3);
            this.CCP.Controls.Add(this.label2);
            this.CCP.Controls.Add(this.label1);
            this.CCP.Location = new System.Drawing.Point(4, 25);
            this.CCP.Name = "CCP";
            this.CCP.Padding = new System.Windows.Forms.Padding(3);
            this.CCP.Size = new System.Drawing.Size(405, 225);
            this.CCP.TabIndex = 0;
            this.CCP.Text = "CCP";
            // 
            // copy
            // 
            this.copy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.copy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(171)))), ((int)(((byte)(128)))));
            this.copy.FlatAppearance.BorderSize = 0;
            this.copy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(199)))), ((int)(((byte)(170)))));
            this.copy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(199)))), ((int)(((byte)(170)))));
            this.copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copy.Image = global::RIB.Properties.Resources.Copy_24x24;
            this.copy.Location = new System.Drawing.Point(332, 125);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(66, 43);
            this.copy.TabIndex = 16;
            this.copy.UseVisualStyleBackColor = false;
            this.copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // all_txt
            // 
            this.all_txt.Font = new System.Drawing.Font("Sakkal Majalla", 14F, System.Drawing.FontStyle.Bold);
            this.all_txt.Location = new System.Drawing.Point(128, 125);
            this.all_txt.MaxLength = 20;
            this.all_txt.Name = "all_txt";
            this.all_txt.ReadOnly = true;
            this.all_txt.Size = new System.Drawing.Size(202, 40);
            this.all_txt.TabIndex = 15;
            // 
            // rip_txt
            // 
            this.rip_txt.Font = new System.Drawing.Font("Sakkal Majalla", 14F, System.Drawing.FontStyle.Bold);
            this.rip_txt.Location = new System.Drawing.Point(294, 74);
            this.rip_txt.MaxLength = 2;
            this.rip_txt.Name = "rip_txt";
            this.rip_txt.ReadOnly = true;
            this.rip_txt.Size = new System.Drawing.Size(36, 40);
            this.rip_txt.TabIndex = 14;
            // 
            // cle_txt
            // 
            this.cle_txt.Font = new System.Drawing.Font("Sakkal Majalla", 14F, System.Drawing.FontStyle.Bold);
            this.cle_txt.Location = new System.Drawing.Point(129, 74);
            this.cle_txt.MaxLength = 2;
            this.cle_txt.Name = "cle_txt";
            this.cle_txt.ReadOnly = true;
            this.cle_txt.Size = new System.Drawing.Size(36, 40);
            this.cle_txt.TabIndex = 13;
            // 
            // cpt_txt
            // 
            this.cpt_txt.Font = new System.Drawing.Font("Sakkal Majalla", 14F, System.Drawing.FontStyle.Bold);
            this.cpt_txt.Location = new System.Drawing.Point(129, 22);
            this.cpt_txt.MaxLength = 10;
            this.cpt_txt.Name = "cpt_txt";
            this.cpt_txt.Size = new System.Drawing.Size(201, 40);
            this.cpt_txt.TabIndex = 12;
            this.cpt_txt.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.cpt_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "COMPTE+RIP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "RIP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "CLE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "COMPTE";
            // 
            // BANQUE
            // 
            this.BANQUE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(153)))));
            this.BANQUE.Controls.Add(this.button1);
            this.BANQUE.Controls.Add(this.textBox1);
            this.BANQUE.Controls.Add(this.textBox2);
            this.BANQUE.Controls.Add(this.textBox4);
            this.BANQUE.Controls.Add(this.label5);
            this.BANQUE.Controls.Add(this.label6);
            this.BANQUE.Controls.Add(this.label8);
            this.BANQUE.Location = new System.Drawing.Point(4, 25);
            this.BANQUE.Name = "BANQUE";
            this.BANQUE.Padding = new System.Windows.Forms.Padding(3);
            this.BANQUE.Size = new System.Drawing.Size(405, 225);
            this.BANQUE.TabIndex = 1;
            this.BANQUE.Text = "BANQUE";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(171)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(187)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(187)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::RIB.Properties.Resources.Copy_24x24;
            this.button1.Location = new System.Drawing.Point(333, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 43);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Sakkal Majalla", 14F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(129, 126);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(202, 40);
            this.textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Sakkal Majalla", 14F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(129, 75);
            this.textBox2.MaxLength = 2;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(36, 40);
            this.textBox2.TabIndex = 23;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Sakkal Majalla", 14F, System.Drawing.FontStyle.Bold);
            this.textBox4.Location = new System.Drawing.Point(130, 23);
            this.textBox4.MaxLength = 18;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(201, 40);
            this.textBox4.TabIndex = 21;
            this.textBox4.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox4_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 32);
            this.label5.TabIndex = 20;
            this.label5.Text = "COMPTE+RIP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 32);
            this.label6.TabIndex = 19;
            this.label6.Text = "RIP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 32);
            this.label8.TabIndex = 17;
            this.label8.Text = "COMPTE";
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip2.Location = new System.Drawing.Point(0, 230);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip2.Size = new System.Drawing.Size(413, 24);
            this.statusStrip2.TabIndex = 18;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(158, 19);
            this.toolStripStatusLabel2.Text = "aliboukhari2991@gmail.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 254);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "relevé d\'identité bancaire/postal";
            this.tabControl1.ResumeLayout(false);
            this.CCP.ResumeLayout(false);
            this.CCP.PerformLayout();
            this.BANQUE.ResumeLayout(false);
            this.BANQUE.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CCP;
        private System.Windows.Forms.TabPage BANQUE;
        private System.Windows.Forms.TextBox all_txt;
        private System.Windows.Forms.TextBox rip_txt;
        private System.Windows.Forms.TextBox cle_txt;
        private System.Windows.Forms.TextBox cpt_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

