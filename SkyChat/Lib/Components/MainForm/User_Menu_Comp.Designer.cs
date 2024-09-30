namespace SkyChat.Lib.Components.MainForm
{
    partial class User_Menu_Comp
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
            this.panelMenuUser = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.Refresh = new Guna.UI2.WinForms.Guna2Button();
            this.panelMenuUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuUser
            // 
            this.panelMenuUser.BackColor = System.Drawing.Color.Transparent;
            this.panelMenuUser.Controls.Add(this.guna2Button2);
            this.panelMenuUser.Controls.Add(this.Refresh);
            this.panelMenuUser.CustomizableEdges.BottomLeft = false;
            this.panelMenuUser.CustomizableEdges.BottomRight = false;
            this.panelMenuUser.CustomizableEdges.TopLeft = false;
            this.panelMenuUser.CustomizableEdges.TopRight = false;
            this.panelMenuUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.panelMenuUser.Location = new System.Drawing.Point(0, 0);
            this.panelMenuUser.Name = "panelMenuUser";
            this.panelMenuUser.Size = new System.Drawing.Size(169, 74);
            this.panelMenuUser.TabIndex = 2;
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(203)))));
            this.guna2Button2.Location = new System.Drawing.Point(2, 37);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(163, 34);
            this.guna2Button2.TabIndex = 1;
            this.guna2Button2.Text = "Delete";
            // 
            // Refresh
            // 
            this.Refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Refresh.FillColor = System.Drawing.Color.Transparent;
            this.Refresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(203)))));
            this.Refresh.Location = new System.Drawing.Point(2, 2);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(163, 34);
            this.Refresh.TabIndex = 0;
            this.Refresh.Text = "Refresh";
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // User_Menu_Comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMenuUser);
            this.Name = "User_Menu_Comp";
            this.Size = new System.Drawing.Size(169, 74);
            this.panelMenuUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelMenuUser;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button Refresh;
    }
}
