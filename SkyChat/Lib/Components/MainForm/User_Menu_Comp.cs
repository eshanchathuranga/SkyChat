using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyChat.Lib.Components.MainForm
{
    public partial class User_Menu_Comp : UserControl
    {
        private string _id;
        UserControl menu;
        Panel mainPanel;
        public User_Menu_Comp(string id)
        {
            InitializeComponent();
            this.Name = id;
            this._id = id;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {



        }


    }
}
