using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyChat.Lib.Components.MainForm
{
    public partial class User_Header_Comp : UserControl
    {
        private string _id;
        Panel mainPanel;
        public User_Header_Comp(string username, string email, string id)
        {
            InitializeComponent();
            lableHeaderUserName.Text = username;
            lableHeaderEmail.Text = email;
            this._id = id;
        }


        // ------------------ Bug In It-----------
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form mainForm = this.FindForm();
            Panel mainPanel = (Panel)mainForm.Controls.Find("panelChatMainContainer", true).FirstOrDefault();
            User_Menu_Comp user_Menu_Comp = new User_Menu_Comp(_id);
            user_Menu_Comp.Location = new Point(0, 0);

            // Remove existing User_Menu_Comp with the same ID if it exists
            var existingMenu = mainPanel.Controls.OfType<User_Menu_Comp>().FirstOrDefault(menu => menu.Name == this._id);
            if (existingMenu != null)
            {
                mainPanel.Controls.Remove(existingMenu);
            }

            // Add the new User_Menu_Comp
            mainPanel.Controls.Add(user_Menu_Comp);
        }


    }
}
