namespace OrderingSystem.KioskApplication.Forms
{
    partial class Dashboard
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
            this.mm = new Guna.UI2.WinForms.Guna2Panel();
            this.bb = new Guna.UI2.WinForms.Guna2Panel();
            this.b2 = new Guna.UI2.WinForms.Guna2Button();
            this.b1 = new Guna.UI2.WinForms.Guna2Button();
            this.mm.SuspendLayout();
            this.bb.SuspendLayout();
            this.SuspendLayout();
            // 
            // mm
            // 
            this.mm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mm.BackColor = System.Drawing.Color.White;
            this.mm.Controls.Add(this.bb);
            this.mm.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mm.Location = new System.Drawing.Point(0, 0);
            this.mm.MaximumSize = new System.Drawing.Size(1920, 2000);
            this.mm.MinimumSize = new System.Drawing.Size(1300, 700);
            this.mm.Name = "mm";
            this.mm.ShadowDecoration.Color = System.Drawing.Color.DarkTurquoise;
            this.mm.ShadowDecoration.Depth = 255;
            this.mm.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.mm.Size = new System.Drawing.Size(1301, 702);
            this.mm.TabIndex = 0;
            // 
            // bb
            // 
            this.bb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bb.BackColor = System.Drawing.Color.Transparent;
            this.bb.Controls.Add(this.b2);
            this.bb.Controls.Add(this.b1);
            this.bb.Location = new System.Drawing.Point(12, 12);
            this.bb.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.bb.MinimumSize = new System.Drawing.Size(1276, 676);
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(1276, 676);
            this.bb.TabIndex = 2;
            this.bb.UseTransparentBackground = true;
            // 
            // b2
            // 
            this.b2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b2.BackColor = System.Drawing.Color.Transparent;
            this.b2.BorderRadius = 20;
            this.b2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b2.Font = new System.Drawing.Font("Segoe UI Black", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.ForeColor = System.Drawing.Color.White;
            this.b2.Location = new System.Drawing.Point(670, 142);
            this.b2.Name = "b2";
            this.b2.ShadowDecoration.BorderRadius = 20;
            this.b2.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.b2.ShadowDecoration.Depth = 100;
            this.b2.ShadowDecoration.Enabled = true;
            this.b2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.b2.Size = new System.Drawing.Size(420, 320);
            this.b2.TabIndex = 0;
            this.b2.Text = "DINE-IN";
            this.b2.Click += new System.EventHandler(this.dinein);
            // 
            // b1
            // 
            this.b1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b1.BackColor = System.Drawing.Color.Transparent;
            this.b1.BorderRadius = 20;
            this.b1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b1.Font = new System.Drawing.Font("Segoe UI Black", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.ForeColor = System.Drawing.Color.White;
            this.b1.Location = new System.Drawing.Point(197, 142);
            this.b1.Name = "b1";
            this.b1.ShadowDecoration.BorderRadius = 20;
            this.b1.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.b1.ShadowDecoration.Depth = 100;
            this.b1.ShadowDecoration.Enabled = true;
            this.b1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.b1.Size = new System.Drawing.Size(420, 320);
            this.b1.TabIndex = 1;
            this.b1.Text = "TAKE-OUT";
            this.b1.Click += new System.EventHandler(this.takeout);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.mm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 2000);
            this.MinimumSize = new System.Drawing.Size(1300, 700);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mm.ResumeLayout(false);
            this.bb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mm;
        private Guna.UI2.WinForms.Guna2Button b1;
        private Guna.UI2.WinForms.Guna2Button b2;
        private Guna.UI2.WinForms.Guna2Panel bb;
    }
}