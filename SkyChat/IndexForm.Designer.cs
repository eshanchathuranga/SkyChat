namespace SkyChat
{
    partial class IndexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexForm));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelIndexContainer = new System.Windows.Forms.Panel();
            this.btnIndexClose = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnIndexClose);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(289, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(387, 27);
            this.guna2Panel1.TabIndex = 10;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // panelIndexContainer
            // 
            this.panelIndexContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIndexContainer.Location = new System.Drawing.Point(289, 27);
            this.panelIndexContainer.Name = "panelIndexContainer";
            this.panelIndexContainer.Padding = new System.Windows.Forms.Padding(30, 0, 30, 30);
            this.panelIndexContainer.Size = new System.Drawing.Size(387, 384);
            this.panelIndexContainer.TabIndex = 9;
            this.panelIndexContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelIndexContainer_Paint);
            // 
            // btnIndexClose
            // 
            this.btnIndexClose.AutoRoundedCorners = true;
            this.btnIndexClose.BorderRadius = 9;
            this.btnIndexClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIndexClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIndexClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIndexClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIndexClose.FillColor = System.Drawing.Color.Transparent;
            this.btnIndexClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIndexClose.ForeColor = System.Drawing.Color.White;
            this.btnIndexClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(175)))), ((int)(((byte)(226)))));
            this.btnIndexClose.Image = global::SkyChat.Properties.Resources.Close_icon__2_;
            this.btnIndexClose.Location = new System.Drawing.Point(358, 4);
            this.btnIndexClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnIndexClose.Name = "btnIndexClose";
            this.btnIndexClose.Size = new System.Drawing.Size(26, 20);
            this.btnIndexClose.TabIndex = 0;
            this.btnIndexClose.Click += new System.EventHandler(this.btnIndexClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 411);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 411);
            this.Controls.Add(this.panelIndexContainer);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IndexForm";
            this.Load += new System.EventHandler(this.IndexForm_Load_1);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnIndexClose;
        private System.Windows.Forms.Panel panelIndexContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

