namespace menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ulaz_hem_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.Skladiste_btn = new System.Windows.Forms.Button();
            this.hemija_btn = new System.Windows.Forms.Button();
            this.dock_uc_pan = new System.Windows.Forms.Panel();
            this.DIK_btn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.DIK_btn);
            this.panel2.Controls.Add(this.ulaz_hem_btn);
            this.panel2.Controls.Add(this.exit_btn);
            this.panel2.Controls.Add(this.Skladiste_btn);
            this.panel2.Controls.Add(this.hemija_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 479);
            this.panel2.TabIndex = 1;
            // 
            // ulaz_hem_btn
            // 
            this.ulaz_hem_btn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ulaz_hem_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ulaz_hem_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ulaz_hem_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.ulaz_hem_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ulaz_hem_btn.Location = new System.Drawing.Point(0, 68);
            this.ulaz_hem_btn.Name = "ulaz_hem_btn";
            this.ulaz_hem_btn.Size = new System.Drawing.Size(200, 34);
            this.ulaz_hem_btn.TabIndex = 3;
            this.ulaz_hem_btn.Text = "Ulaz hemije";
            this.ulaz_hem_btn.UseVisualStyleBackColor = false;
            this.ulaz_hem_btn.Click += new System.EventHandler(this.ulaz_hem_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.exit_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exit_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Location = new System.Drawing.Point(0, 437);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(200, 42);
            this.exit_btn.TabIndex = 2;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // Skladiste_btn
            // 
            this.Skladiste_btn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Skladiste_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Skladiste_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Skladiste_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.Skladiste_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Skladiste_btn.Location = new System.Drawing.Point(0, 34);
            this.Skladiste_btn.Name = "Skladiste_btn";
            this.Skladiste_btn.Size = new System.Drawing.Size(200, 34);
            this.Skladiste_btn.TabIndex = 1;
            this.Skladiste_btn.Text = "Skladište hemije";
            this.Skladiste_btn.UseVisualStyleBackColor = false;
            this.Skladiste_btn.Click += new System.EventHandler(this.Skladiste_btn_Click);
            // 
            // hemija_btn
            // 
            this.hemija_btn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hemija_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.hemija_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hemija_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.hemija_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hemija_btn.Location = new System.Drawing.Point(0, 0);
            this.hemija_btn.Name = "hemija_btn";
            this.hemija_btn.Size = new System.Drawing.Size(200, 34);
            this.hemija_btn.TabIndex = 0;
            this.hemija_btn.Text = "Unos hemije";
            this.hemija_btn.UseVisualStyleBackColor = false;
            this.hemija_btn.Click += new System.EventHandler(this.hemija_btn_Click);
            // 
            // dock_uc_pan
            // 
            this.dock_uc_pan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dock_uc_pan.Location = new System.Drawing.Point(200, 100);
            this.dock_uc_pan.Name = "dock_uc_pan";
            this.dock_uc_pan.Size = new System.Drawing.Size(914, 479);
            this.dock_uc_pan.TabIndex = 2;
            // 
            // DIK_btn
            // 
            this.DIK_btn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DIK_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DIK_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DIK_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.DIK_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DIK_btn.Location = new System.Drawing.Point(0, 102);
            this.DIK_btn.Name = "DIK_btn";
            this.DIK_btn.Size = new System.Drawing.Size(200, 34);
            this.DIK_btn.TabIndex = 4;
            this.DIK_btn.Text = "DIK";
            this.DIK_btn.UseVisualStyleBackColor = false;
            this.DIK_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 579);
            this.Controls.Add(this.dock_uc_pan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button hemija_btn;
        private System.Windows.Forms.Button Skladiste_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Panel dock_uc_pan;
        private System.Windows.Forms.Button ulaz_hem_btn;
        private System.Windows.Forms.Button DIK_btn;
    }
}

