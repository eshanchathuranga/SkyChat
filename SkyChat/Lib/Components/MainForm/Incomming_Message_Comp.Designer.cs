namespace SkyChat.Lib.Components.MainForm
{
    partial class Incomming_Message_Comp
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
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.lableTimeStamp = new System.Windows.Forms.Label();
            this.lableIncomeMessage = new System.Windows.Forms.Label();
            this.guna2Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Controls.Add(this.lableTimeStamp);
            this.guna2Panel5.Controls.Add(this.lableIncomeMessage);
            this.guna2Panel5.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(784, 33);
            this.guna2Panel5.TabIndex = 3;
            // 
            // lableTimeStamp
            // 
            this.lableTimeStamp.AutoSize = true;
            this.lableTimeStamp.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableTimeStamp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(89)))));
            this.lableTimeStamp.Location = new System.Drawing.Point(3, 9);
            this.lableTimeStamp.Name = "lableTimeStamp";
            this.lableTimeStamp.Size = new System.Drawing.Size(69, 17);
            this.lableTimeStamp.TabIndex = 1;
            this.lableTimeStamp.Text = "12.00 PM  :";
            // 
            // lableIncomeMessage
            // 
            this.lableIncomeMessage.AutoSize = true;
            this.lableIncomeMessage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableIncomeMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(89)))));
            this.lableIncomeMessage.Location = new System.Drawing.Point(68, 5);
            this.lableIncomeMessage.Name = "lableIncomeMessage";
            this.lableIncomeMessage.Size = new System.Drawing.Size(107, 23);
            this.lableIncomeMessage.TabIndex = 0;
            this.lableIncomeMessage.Text = "Hellow there!";
            // 
            // Incomming_Message_Comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel5);
            this.Name = "Incomming_Message_Comp";
            this.Size = new System.Drawing.Size(784, 33);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label lableTimeStamp;
        private System.Windows.Forms.Label lableIncomeMessage;
    }
}
