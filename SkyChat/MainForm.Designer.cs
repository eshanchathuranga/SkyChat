namespace SkyChat
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelMainUserContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearchInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panalMessageSend = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMessageInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelUserHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.panelChatMainContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.lableSelectChat = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnMessageSend = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnAcountSettings = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.panalMessageSend.SuspendLayout();
            this.panelChatMainContainer.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(89)))));
            this.guna2Panel1.Controls.Add(this.panelMainUserContainer);
            this.guna2Panel1.Controls.Add(this.guna2Panel4);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(89)))));
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(239, 589);
            this.guna2Panel1.TabIndex = 2;
            // 
            // panelMainUserContainer
            // 
            this.panelMainUserContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainUserContainer.Location = new System.Drawing.Point(0, 110);
            this.panelMainUserContainer.Name = "panelMainUserContainer";
            this.panelMainUserContainer.Size = new System.Drawing.Size(239, 479);
            this.panelMainUserContainer.TabIndex = 2;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.btnSearch);
            this.guna2Panel4.Controls.Add(this.txtSearchInput);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 57);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(239, 53);
            this.guna2Panel4.TabIndex = 1;
            // 
            // txtSearchInput
            // 
            this.txtSearchInput.AutoRoundedCorners = true;
            this.txtSearchInput.BorderRadius = 11;
            this.txtSearchInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchInput.DefaultText = "";
            this.txtSearchInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(217)))), ((int)(((byte)(234)))));
            this.txtSearchInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(83)))), ((int)(((byte)(164)))));
            this.txtSearchInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchInput.Location = new System.Drawing.Point(4, 12);
            this.txtSearchInput.Name = "txtSearchInput";
            this.txtSearchInput.PasswordChar = '\0';
            this.txtSearchInput.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtSearchInput.PlaceholderText = "Search by username";
            this.txtSearchInput.SelectedText = "";
            this.txtSearchInput.Size = new System.Drawing.Size(223, 25);
            this.txtSearchInput.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btnAcountSettings);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(217)))), ((int)(((byte)(234)))));
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(239, 57);
            this.guna2Panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sky Chat";
            // 
            // panalMessageSend
            // 
            this.panalMessageSend.Controls.Add(this.btnMessageSend);
            this.panalMessageSend.Controls.Add(this.txtMessageInput);
            this.panalMessageSend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panalMessageSend.Location = new System.Drawing.Point(239, 532);
            this.panalMessageSend.Name = "panalMessageSend";
            this.panalMessageSend.Size = new System.Drawing.Size(794, 57);
            this.panalMessageSend.TabIndex = 5;
            // 
            // txtMessageInput
            // 
            this.txtMessageInput.AutoRoundedCorners = true;
            this.txtMessageInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.txtMessageInput.BorderRadius = 19;
            this.txtMessageInput.BorderThickness = 2;
            this.txtMessageInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessageInput.DefaultText = "";
            this.txtMessageInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMessageInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMessageInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessageInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessageInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(217)))), ((int)(((byte)(234)))));
            this.txtMessageInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessageInput.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(203)))));
            this.txtMessageInput.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageInput.ForeColor = System.Drawing.Color.Black;
            this.txtMessageInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessageInput.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(216)))), ((int)(((byte)(203)))));
            this.txtMessageInput.Location = new System.Drawing.Point(5, 10);
            this.txtMessageInput.Margin = new System.Windows.Forms.Padding(5, 11, 5, 11);
            this.txtMessageInput.Name = "txtMessageInput";
            this.txtMessageInput.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txtMessageInput.PasswordChar = '\0';
            this.txtMessageInput.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMessageInput.PlaceholderText = "Type new message here.......";
            this.txtMessageInput.SelectedText = "";
            this.txtMessageInput.Size = new System.Drawing.Size(729, 40);
            this.txtMessageInput.TabIndex = 0;
            // 
            // panelUserHeader
            // 
            this.panelUserHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.panelUserHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserHeader.Location = new System.Drawing.Point(46, 0);
            this.panelUserHeader.Name = "panelUserHeader";
            this.panelUserHeader.Size = new System.Drawing.Size(748, 57);
            this.panelUserHeader.TabIndex = 6;
            // 
            // panelChatMainContainer
            // 
            this.panelChatMainContainer.AutoScroll = true;
            this.panelChatMainContainer.Controls.Add(this.lableSelectChat);
            this.panelChatMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChatMainContainer.Location = new System.Drawing.Point(239, 57);
            this.panelChatMainContainer.Name = "panelChatMainContainer";
            this.panelChatMainContainer.Size = new System.Drawing.Size(794, 475);
            this.panelChatMainContainer.TabIndex = 7;
            this.panelChatMainContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChatMainContainer_Paint);
            // 
            // lableSelectChat
            // 
            this.lableSelectChat.AutoSize = true;
            this.lableSelectChat.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableSelectChat.ForeColor = System.Drawing.Color.Gray;
            this.lableSelectChat.Location = new System.Drawing.Point(301, 230);
            this.lableSelectChat.Name = "lableSelectChat";
            this.lableSelectChat.Size = new System.Drawing.Size(180, 29);
            this.lableSelectChat.TabIndex = 0;
            this.lableSelectChat.Text = "Select a chat to start messaging...";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.guna2Panel3.Controls.Add(this.panelUserHeader);
            this.guna2Panel3.Controls.Add(this.guna2Button1);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(239, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(794, 57);
            this.guna2Panel3.TabIndex = 2;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Silver;
            this.guna2Button1.Image = global::SkyChat.Properties.Resources.Back_icon;
            this.guna2Button1.Location = new System.Drawing.Point(0, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(46, 57);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnMessageSend
            // 
            this.btnMessageSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMessageSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMessageSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMessageSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMessageSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMessageSend.FillColor = System.Drawing.Color.Transparent;
            this.btnMessageSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMessageSend.ForeColor = System.Drawing.Color.White;
            this.btnMessageSend.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnMessageSend.Image = global::SkyChat.Properties.Resources.Send_Icon;
            this.btnMessageSend.ImageSize = new System.Drawing.Size(40, 40);
            this.btnMessageSend.Location = new System.Drawing.Point(739, 0);
            this.btnMessageSend.Margin = new System.Windows.Forms.Padding(0);
            this.btnMessageSend.Name = "btnMessageSend";
            this.btnMessageSend.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(217)))), ((int)(((byte)(234)))));
            this.btnMessageSend.Size = new System.Drawing.Size(55, 57);
            this.btnMessageSend.TabIndex = 1;
            this.btnMessageSend.Click += new System.EventHandler(this.btnMessageSend_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoRoundedCorners = true;
            this.btnSearch.BorderRadius = 11;
            this.btnSearch.CustomizableEdges.BottomLeft = false;
            this.btnSearch.CustomizableEdges.TopLeft = false;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(217)))), ((int)(((byte)(234)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::SkyChat.Properties.Resources.Srearch_icon2;
            this.btnSearch.Location = new System.Drawing.Point(197, 12);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAcountSettings
            // 
            this.btnAcountSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnAcountSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAcountSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAcountSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAcountSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAcountSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAcountSettings.FillColor = System.Drawing.Color.Transparent;
            this.btnAcountSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAcountSettings.ForeColor = System.Drawing.Color.White;
            this.btnAcountSettings.Image = global::SkyChat.Properties.Resources.Menu_icon;
            this.btnAcountSettings.ImageSize = new System.Drawing.Size(40, 50);
            this.btnAcountSettings.Location = new System.Drawing.Point(185, 0);
            this.btnAcountSettings.Name = "btnAcountSettings";
            this.btnAcountSettings.PressedColor = System.Drawing.Color.Transparent;
            this.btnAcountSettings.PressedDepth = 0;
            this.btnAcountSettings.Size = new System.Drawing.Size(54, 57);
            this.btnAcountSettings.TabIndex = 1;
            this.btnAcountSettings.UseTransparentBackground = true;
            this.btnAcountSettings.Click += new System.EventHandler(this.btnAcountSettings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1033, 589);
            this.Controls.Add(this.panelChatMainContainer);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.panalMessageSend);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sky Chat";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.panalMessageSend.ResumeLayout(false);
            this.panelChatMainContainer.ResumeLayout(false);
            this.panelChatMainContainer.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panelMainUserContainer;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchInput;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnAcountSettings;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel panalMessageSend;
        private Guna.UI2.WinForms.Guna2Button btnMessageSend;
        private Guna.UI2.WinForms.Guna2TextBox txtMessageInput;
        private Guna.UI2.WinForms.Guna2Panel panelUserHeader;
        private Guna.UI2.WinForms.Guna2Panel panelChatMainContainer;
        private System.Windows.Forms.Label lableSelectChat;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}