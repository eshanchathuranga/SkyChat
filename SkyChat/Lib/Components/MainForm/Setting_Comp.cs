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
        public Setting_Comp()
        {
            InitializeComponent();
            // Create a object og get file path
            this.getFilePath = new GetFilePath();
            // Get File path
            this.AuthConfigPath = getFilePath.GetConfigFilePath("AuthConfig.json");
            // Read the AuthConfig file
            string json = System.IO.File.ReadAllText(AuthConfigPath);
            this.authConfig = JsonConvert.DeserializeObject<AuthConfig>(json);
            this._authEmail = this.authConfig.email;
            this._authId = this.authConfig._id;
            this._authUsername = this.authConfig.username;
            this.ServerConnection = new ServerConnection();
            lableInfoEmail.Text = this._authEmail;
            lableInfoUsername.Text = this._authUsername;
            lableInfoId.Text = this._authId;
            // Hide the input field and save button
            lableHeaderEditSetting.Visible = false;
            txtInputFeaild.Visible = false;
            btnSave.Visible = false;


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string inputValue = txtInputFeaild.Text.ToString();
            Task.Run(() =>
            {
                if (this.modificationType == "username")
                {
                    string rout = $"update?authId={this.authConfig._id}";
                    string data = $@"{{""path"": ""username"", ""data"": ""{inputValue}""}}";
                    string response = ServerConnection.PostDataAsync(rout, data).Result;
                    responseData = JsonConvert.DeserializeObject<ResponseData>(response);
                    if (responseData.code)
                    {
                        this.Invoke((MethodInvoker)delegate {
                            lableInfoUsername.Text = inputValue;
                            this.authConfig.username = inputValue;
                            string updateData = JsonConvert.SerializeObject(authConfig);
                            File.WriteAllText(AuthConfigPath, updateData);
                            lableHeaderEditSetting.Visible = false;
                            txtInputFeaild.Visible = false;
                            btnSave.Visible = false;
                        });
                    }
                    else
                    {
                        MessageBox.Show(responseData.message);
                    }
                }
                if (this.modificationType == "email")
                {
                    string rout = $"update?authId={this.authConfig._id}";
                    string data = $@"{{""path"": ""email"", ""data"": ""{inputValue}""}}";
                    string response = ServerConnection.PostDataAsync(rout, data).Result;
                    responseData = JsonConvert.DeserializeObject<ResponseData>(response);
                    if (responseData.code)
                    {
                        this.Invoke((MethodInvoker)delegate {
                            lableInfoEmail.Text = inputValue;
                            this.authConfig.email = inputValue;
                            string updateData = JsonConvert.SerializeObject(authConfig);
                            File.WriteAllText(AuthConfigPath, updateData);
                            lableHeaderEditSetting.Visible = false;
                            txtInputFeaild.Visible = false;
                            btnSave.Visible = false;
                        });
                    }
                    else
                    {
                        MessageBox.Show(responseData.message);
                    }
                }
                if (this.modificationType == "password")
                {
                    string rout = $"update?authId={this.authConfig._id}";
                    string data = $@"{{""path"": ""password"", ""data"": ""{inputValue}""}}";
                    string response = ServerConnection.PostDataAsync(rout, data).Result;
                    responseData = JsonConvert.DeserializeObject<ResponseData>(response);
                    if (responseData.code)
                    {
                        this.Invoke((MethodInvoker)delegate {
                            lableHeaderEditSetting.Visible = false;
                            txtInputFeaild.Visible = false;
                            btnSave.Visible = false;
                        });
                    }
                    else
                    {
                        MessageBox.Show(responseData.message);
                    }
                }
            });
        }

        private void Setting_Comp_Load(object sender, EventArgs e)
        {
            

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
            lableHeaderEditSetting.Visible = true;
            txtInputFeaild.Visible = true;
            btnSave.Visible = true;
            txtInputFeaild.Clear();
            lableHeaderEditSetting.Text = "Change Username";
            txtInputFeaild.PlaceholderText = "Enter New Username";
            this.modificationType = "username";
        }

        private void linkButtonChangeEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lableHeaderEditSetting.Visible = true;
            txtInputFeaild.Visible = true;
            btnSave.Visible = true;
            txtInputFeaild.Clear();
            lableHeaderEditSetting.Text = "Change Email";
            txtInputFeaild.PlaceholderText = "Enter New Email";
            this.modificationType = "email";
        }

        private void linkButtonChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lableHeaderEditSetting.Visible = true;
            txtInputFeaild.Visible = true;
            btnSave.Visible = true;
            txtInputFeaild.Clear();
            lableHeaderEditSetting.Text = "Change  Password";
            txtInputFeaild.PlaceholderText = "Enter New Password";
            this.modificationType = "password";
        }

        private void linkButtonLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Remove Config Data
            authConfig._id = null;
            authConfig.email = null;
            authConfig.password = null;
            authConfig.username = null;
            authConfig.picUrl = null;
            string removeData = JsonConvert.SerializeObject(authConfig);
            File.WriteAllText(AuthConfigPath, removeData);
            Form mainForm = this.FindForm();
            SkyChat.IndexForm indexForm = new SkyChat.IndexForm();
            indexForm.Show();
            mainForm.Hide();
        }
    }
}
