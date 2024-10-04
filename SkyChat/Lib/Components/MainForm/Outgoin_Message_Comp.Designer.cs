namespace SkyChat.Lib.Components.MainForm
{
    partial class Outgoin_Message_Comp
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
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.lableTimeStamp = new System.Windows.Forms.Label();
            this.lableMsg = new System.Windows.Forms.Label();
            this.guna2Panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.Controls.Add(this.lableTimeStamp);
            this.guna2Panel7.Controls.Add(this.lableMsg);
            this.guna2Panel7.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel7.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(784, 33);
            this.guna2Panel7.TabIndex = 4;
            // 
            // lableTimeStamp
            // 
            this.lableTimeStamp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lableTimeStamp.AutoSize = true;
            this.lableTimeStamp.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableTimeStamp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(89)))));
            this.lableTimeStamp.Location = new System.Drawing.Point(715, 9);
            this.lableTimeStamp.Name = "lableTimeStamp";
            this.lableTimeStamp.Size = new System.Drawing.Size(65, 17);
            this.lableTimeStamp.TabIndex = 1;
            this.lableTimeStamp.Text = ": 12.00 PM";
            // 
            // lableMsg
            // 
            this.lableMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lableMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lableMsg.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(89)))));
            this.lableMsg.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lableMsg.Location = new System.Drawing.Point(3, 5);
            this.lableMsg.Name = "lableMsg";
            this.lableMsg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lableMsg.Size = new System.Drawing.Size(714, 23);
            this.lableMsg.TabIndex = 0;
            this.lableMsg.Text = "hellow ";
            this.lableMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Outgoin_Message_Comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel7);
            this.Name = "Outgoin_Message_Comp";
            this.Size = new System.Drawing.Size(784, 33);
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private System.Windows.Forms.Label lableTimeStamp;
        private System.Windows.Forms.Label lableMsg;
    }
}
