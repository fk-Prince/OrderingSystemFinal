namespace OrderingSystem.KioskApplication.Component
{
    partial class MyRadioButton2
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
            this.name = new System.Windows.Forms.Label();
            this.radio = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoEllipsis = true;
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(37, -1);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(119, 21);
            this.name.TabIndex = 8;
            this.name.Text = "Category Name";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // radio
            // 
            this.radio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radio.CheckedState.BorderThickness = 0;
            this.radio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radio.Location = new System.Drawing.Point(16, 3);
            this.radio.Name = "radio";
            this.radio.Size = new System.Drawing.Size(15, 15);
            this.radio.TabIndex = 7;
            this.radio.Text = "guna2CustomRadioButton1";
            this.radio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radio.UncheckedState.BorderThickness = 2;
            this.radio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radio.Click += new System.EventHandler(this.clicked);
            // 
            // MyRadioButton2
            // 
            this.ClientSize = new System.Drawing.Size(201, 22);
            this.Controls.Add(this.name);
            this.Controls.Add(this.radio);
            this.Name = "MyRadioButton2";
            this.Text = "MyRadioButton2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label name;
        public Guna.UI2.WinForms.Guna2CustomRadioButton radio;
    }
}