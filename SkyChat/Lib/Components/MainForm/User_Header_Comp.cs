using SkyChat.Lib.Modules;
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
using static SkyChat.MainForm;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace SkyChat.Lib.Components.MainForm
{
    public partial class User_Header_Comp : UserControl
    {
        // Define a object og Get File Path
        GetFilePath getFilePath;
        private string _id;
        private string _username;
        private string _picUrl;
        private string UsersAccountsPath;
        // Create a object of Users Accounts
        UsersAccount usersAccounts;
        public User_Header_Comp(string username, string email, string id, string url)
        {
            InitializeComponent();
            // Create a object og get file path
            this.getFilePath = new GetFilePath();
            // Get File path
            this.UsersAccountsPath = getFilePath.GetConfigFilePath("UsersAccounts.json");
            // Read File
            string jsonAccounts = System.IO.File.ReadAllText(UsersAccountsPath);
            usersAccounts = JsonConvert.DeserializeObject<UsersAccount>(jsonAccounts);
            lableHeaderUserName.Text = username;
            lableHeaderEmail.Text = email;
            this._id = id;
            this.Name = id;
            this._username = username;
            this._picUrl = url;

        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // Delete User in User List
            usersAccounts.accounts.Remove(_username);
            // Write the new data to the file
            System.IO.File.WriteAllText(UsersAccountsPath, JsonConvert.SerializeObject(usersAccounts));
            // Remove the user lable
            Form mainForm = this.FindForm();
            Panel usersPanel = (Panel)mainForm.Controls.Find("panelMainUserContainer", true)[0];
            UserControl user = (UserControl)usersPanel.Controls.Find(_id, true)[0];
            usersPanel.Controls.Remove(user);
            usersPanel.Update();
            // Remove Header
            Panel header = (Panel)mainForm.Controls.Find("panelUserHeader", true)[0];
            UserControl userControl = (UserControl)header.Controls.Find(_id, true)[0];
            header.Controls.Remove(userControl);
            header.Refresh();



        }
        // Create a class to store ther usersAccounts data
        public class UsersAccount
        {
            public List<string> accounts { get; set; }
        }

        private void User_Header_Comp_Load(object sender, EventArgs e)
        {
            // Validate pictureUrl
            if (!string.IsNullOrEmpty(this._picUrl))
            {
                using (var webClient = new WebClient())
                {
                    byte[] imageBytes = webClient.DownloadData(this._picUrl);
                    using (var ms = new MemoryStream(imageBytes))
                    {
                        userImage.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
            }
            else
            {
                // Handle null or empty pictureUrl (e.g., set a default image)
                return;
            }

        }
    }
}
