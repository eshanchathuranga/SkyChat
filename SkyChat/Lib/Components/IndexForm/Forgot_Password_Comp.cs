using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyChat.Lib.Components.IndexForm
{
    public partial class Forgot_Password_Comp : UserControl
    {
        public Forgot_Password_Comp()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form IindexForm = this.FindForm();
            Panel indexPanel = (Panel)IindexForm.Controls.Find("panelIndexContainer", true)[0];
            indexPanel.Controls.Clear();
            Login_Account_Comp login_Account_Comp = new Login_Account_Comp();
            login_Account_Comp.Location = new Point(0, 0);
            indexPanel.Controls.Add(login_Account_Comp);
        }
    }
}
