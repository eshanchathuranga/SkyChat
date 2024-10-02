using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SkyChat.Lib.Modules;
using System.IO;
using static SkyChat.IndexForm;

namespace SkyChat.Lib.Components.MainForm
{
    public partial class Setting_Comp : UserControl
    {
        // Define a object og Get File Path
        GetFilePath getFilePath;
        // Define a AuthConfig File Path
        private string AuthConfigPath;
        // Create a object of AuthConfig
        AuthConfig authConfig;
        // Create a object of ServerConnection
        ServerConnection ServerConnection;
        // Create a object of Auth
        private string _authId;
        private string _authUsername;
        private string _authEmail;
        // Crate a object of ResponseData
        ResponseData responseData;
        // Crate a object of Modification type
        private string modificationType;
        // User Control Constructor
        public Setting_Comp()
        {
            InitializeComponent();
            // Create a new objet of ServerConnection
            this.ServerConnection = new ServerConnection();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
        // Form Load Event
        private void Setting_Comp_Load(object sender, EventArgs e)
        {
            // Get the AuthConfig file path
            this.getFilePath = new GetFilePath();
            this.AuthConfigPath = getFilePath.GetConfigFilePath("AuthConfig.json");
            // Read the AuthConfig file
            string json = System.IO.File.ReadAllText(AuthConfigPath);
            authConfig = JsonConvert.DeserializeObject<AuthConfig>(json);
            this._authId = authConfig._id;
            this._authUsername = authConfig.username;
            this._authEmail = authConfig.email;
            lableInfoUsername.Text = this._authUsername;
            lableInfoEmail.Text = this._authEmail;
            lableInfoId.Text = this._authId;
        }

        // Back to main chat
        private void LinkButtonBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form mainForm = this.FindForm();
            Panel panelMainContainer = (Panel)mainForm.Controls.Find("panelChatMainContainer", true)[0];
            Panel panelSendMessage = (Panel)mainForm.Controls.Find("panalMessageSend", true)[0];
            panelMainContainer.Controls.Remove(this);
            panelSendMessage.Visible = true;
        }

        // Create a clsas to store the auth config data
        public class AuthConfig
        {
            public string _id { get; set; }
            public string username { get; set; }
            public string email { get; set; }
            public string password { get; set; }
            public string picUrl { get; set; }
        }
        // Create a class to store the response data
        public class ResponseData
        {
            public string message { get; set; }
            public UserData userData { get; set; }
            public bool code { get; set; }
            public string status { get; set; }
        }
        // Create a class to store the user data
        public class UserData
        {
            public string _id { get; set; }
            public string username { get; set; }
            public string email { get; set; }
            public string password { get; set; }
            public string picUrl { get; set; }
        }

        private void linkButtonChangeUsername_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkButtonChangeEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkButtonChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkButtonLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Edit_Setting_Comp edit_Setting_Comp = new Edit_Setting_Comp(this._authId, "Change Username", "username");
            edit_Setting_Comp.Location = new Point(0,0);
            this.Controls.Clear();
            this.Controls.Add(edit_Setting_Comp);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Edit_Setting_Comp edit_Setting_Comp = new Edit_Setting_Comp(this._authId, "Change Email", "email");
            edit_Setting_Comp.Location = new Point(0, 0);
            this.Controls.Clear();
            this.Controls.Add(edit_Setting_Comp);

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Edit_Setting_Comp edit_Setting_Comp = new Edit_Setting_Comp(this._authId, "Change Password", "password");
            edit_Setting_Comp.Location = new Point(0, 0);
            this.Controls.Clear();
            this.Controls.Add(edit_Setting_Comp);
        }
        // Log out Button Click Event
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete your account?", "Delete Account", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // clear the AuthConfig file
                authConfig._id = null;
                authConfig.username = null;
                authConfig.password = null;
                authConfig.email = null;
                authConfig.picUrl = null;
                string json = JsonConvert.SerializeObject(authConfig);
                System.IO.File.WriteAllText(AuthConfigPath, json);
                // Navigate to the login page
                this.Invoke((MethodInvoker)delegate {
                    Form mainForm = this.FindForm();
                    SkyChat.IndexForm indexForm = new SkyChat.IndexForm();
                    mainForm.Hide();
                    indexForm.Show();
                });
            }
            else
            {
                MessageBox.Show("Failed to delete account");
            }
        }
        // Delete Account Button Click Event
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete your account?", "Delete Account", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Task.Run(() =>
                {
                    // send request to server to delete account
                    string routeName = $"delete?authId={this._authId}";
                    string response = this.ServerConnection.PostDataAsync(routeName, "").Result;
                    // convert response to json object
                    this.responseData = JsonConvert.DeserializeObject<ResponseData>(response);
                    if (this.responseData.code)
                    {
                        // clear the AuthConfig file
                        authConfig._id = null;
                        authConfig.username = null;
                        authConfig.password = null;
                        authConfig.email = null;
                        authConfig.picUrl = null;
                        string json = JsonConvert.SerializeObject(authConfig);
                        System.IO.File.WriteAllText(AuthConfigPath, json);
                        // Navigate to the login page
                        this.Invoke((MethodInvoker)delegate {
                            Form mainForm = this.FindForm();
                            SkyChat.IndexForm indexForm = new SkyChat.IndexForm();
                            mainForm.Hide();
                            indexForm.Show();
                        });
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete account");
                    }
                });
            }
            if (result == DialogResult.No)
            {
                return;
            }
        }
    }
}
