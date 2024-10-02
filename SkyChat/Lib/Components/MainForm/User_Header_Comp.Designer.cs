namespace SkyChat.Lib.Components.MainForm
{
    partial class User_Header_Comp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Header_Comp));
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lableHeaderEmail = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.lableHeaderUserName = new System.Windows.Forms.Label();
            this.userImage = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.guna2Panel3.Controls.Add(this.lableHeaderEmail);
            this.guna2Panel3.Controls.Add(this.guna2Button2);
            this.guna2Panel3.Controls.Add(this.lableHeaderUserName);
            this.guna2Panel3.Controls.Add(this.userImage);
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(748, 57);
            this.guna2Panel3.TabIndex = 4;
            // 
            // lableHeaderEmail
            // 
            this.lableHeaderEmail.AutoSize = true;
            this.lableHeaderEmail.Location = new System.Drawing.Point(64, 32);
            this.lableHeaderEmail.Name = "lableHeaderEmail";
            this.lableHeaderEmail.Size = new System.Drawing.Size(35, 13);
            this.lableHeaderEmail.TabIndex = 3;
            this.lableHeaderEmail.Text = "label1";
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(89)))));
            this.guna2Button2.Image = global::SkyChat.Properties.Resources.Delete_Icon;
            this.guna2Button2.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2Button2.Location = new System.Drawing.Point(685, 0);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.DimGray;
            this.guna2Button2.PressedDepth = 20;
            this.guna2Button2.Size = new System.Drawing.Size(63, 57);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // lableHeaderUserName
            // 
            this.lableHeaderUserName.AutoSize = true;
            this.lableHeaderUserName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableHeaderUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.lableHeaderUserName.Location = new System.Drawing.Point(62, 8);
            this.lableHeaderUserName.Name = "lableHeaderUserName";
            this.lableHeaderUserName.Size = new System.Drawing.Size(145, 23);
            this.lableHeaderUserName.TabIndex = 1;
            this.lableHeaderUserName.Text = "Eshan Chathuranga";
            // 
            // userImage
            // 
            this.userImage.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.userImage.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.userImage.Image = ((System.Drawing.Image)(resources.GetObject("userImage.Image")));
            this.userImage.ImageOffset = new System.Drawing.Point(0, 0);
            this.userImage.ImageRotate = 0F;
            this.userImage.ImageSize = new System.Drawing.Size(50, 50);
            this.userImage.Location = new System.Drawing.Point(6, 3);
            this.userImage.Name = "userImage";
            this.userImage.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.userImage.Size = new System.Drawing.Size(50, 50);
            this.userImage.TabIndex = 0;
            // 
            // User_Header_Comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel3);
            this.Name = "User_Header_Comp";
            this.Size = new System.Drawing.Size(748, 57);
            this.Load += new System.EventHandler(this.User_Header_Comp_Load);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label lableHeaderUserName;
        private Guna.UI2.WinForms.Guna2ImageButton userImage;
        private System.Windows.Forms.Label lableHeaderEmail;
    }
}
