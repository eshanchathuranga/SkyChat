namespace SkyChat.Lib.Components.MainForm
{
    partial class User_Lable_Comp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Lable_Comp));
            this.panelUserBg = new Guna.UI2.WinForms.Guna2Panel();
            this.lableLastMsg = new System.Windows.Forms.Label();
            this.imgUser = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lableUsername = new System.Windows.Forms.Label();
            this.panelUserBg.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUserBg
            // 
            this.panelUserBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(89)))));
            this.panelUserBg.Controls.Add(this.lableLastMsg);
            this.panelUserBg.Controls.Add(this.imgUser);
            this.panelUserBg.Controls.Add(this.lableUsername);
            this.panelUserBg.Location = new System.Drawing.Point(0, 0);
            this.panelUserBg.Name = "panelUserBg";
            this.panelUserBg.Size = new System.Drawing.Size(239, 65);
            this.panelUserBg.TabIndex = 3;
            this.panelUserBg.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUserBg_Paint);
            // 
            // lableLastMsg
            // 
            this.lableLastMsg.AutoSize = true;
            this.lableLastMsg.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableLastMsg.ForeColor = System.Drawing.Color.Silver;
            this.lableLastMsg.Location = new System.Drawing.Point(65, 33);
            this.lableLastMsg.Name = "lableLastMsg";
            this.lableLastMsg.Size = new System.Drawing.Size(97, 17);
            this.lableLastMsg.TabIndex = 2;
            this.lableLastMsg.Text = "No message yet!";
            // 
            // imgUser
            // 
            this.imgUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgUser.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgUser.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.imgUser.Image = ((System.Drawing.Image)(resources.GetObject("imgUser.Image")));
            this.imgUser.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgUser.ImageRotate = 0F;
            this.imgUser.ImageSize = new System.Drawing.Size(50, 50);
            this.imgUser.Location = new System.Drawing.Point(4, 5);
            this.imgUser.Name = "imgUser";
            this.imgUser.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.imgUser.Size = new System.Drawing.Size(55, 55);
            this.imgUser.TabIndex = 1;
            this.imgUser.Click += new System.EventHandler(this.imgUser_Click);
            // 
            // lableUsername
            // 
            this.lableUsername.AutoSize = true;
            this.lableUsername.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.lableUsername.Location = new System.Drawing.Point(65, 14);
            this.lableUsername.Name = "lableUsername";
            this.lableUsername.Size = new System.Drawing.Size(122, 18);
            this.lableUsername.TabIndex = 0;
            this.lableUsername.Text = "Eshan Chathuranga";
            // 
            // User_Lable_Comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelUserBg);
            this.Name = "User_Lable_Comp";
            this.Size = new System.Drawing.Size(239, 65);
            this.Load += new System.EventHandler(this.User_Lable_Comp_Load);
            this.panelUserBg.ResumeLayout(false);
            this.panelUserBg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelUserBg;
        private System.Windows.Forms.Label lableLastMsg;
        private Guna.UI2.WinForms.Guna2ImageButton imgUser;
        private System.Windows.Forms.Label lableUsername;
    }
}
