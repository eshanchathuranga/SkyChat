using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkyChat.Lib.Components.MainForm;
using SkyChat.Lib.Modules;
using Newtonsoft.Json;

namespace SkyChat.Lib.Components
{
    public partial class Edit_Setting_Comp : UserControl
    {
        // Define a object og Get File Path
        GetFilePath getFilePath;
        // Define a AuthConfig File Path
        private string AuthConfigPath;
        // Define a Option
        private string _option;
        private string _authId;
        // Create a object of server connection
        ServerConnection ServerConnection;
        // Create a object of ResponseData
        ResponseData responseData;
        // Create a object of AuthConfig
        AuthConfig authConfig;
        // User Control Constructor
        public Edit_Setting_Comp(string authId, string lableData, string option)
        {
            InitializeComponent();
            // Create new ServerConnection
            this.ServerConnection = new ServerConnection();
            // Create a object og get file path
            this.getFilePath = new GetFilePath();
            // Get File path
            this.AuthConfigPath = getFilePath.GetConfigFilePath("AuthConfig.json");
            // Read the AuthConfig file
            string json = System.IO.File.ReadAllText(AuthConfigPath);
            authConfig = JsonConvert.DeserializeObject<AuthConfig>(json);
            // Set the lable data
            this.lableEdieSetting.Text = lableData;
            this._option = option;
            this._authId = authId;
        }
        // Submit button click event
        private void buttonEsitSettingSubmit_Click(object sender, EventArgs e)
        {
            string inputData = txtEditSettingInput.Text;
            Task.Run(() =>
            {
                if (this._option == "username")
                {
                    // send request to server to update username
                    string routeName = $"update?authId={this._authId}&option=username";
                    string data = $"{{\"data\": \"{inputData}\"}}";
                    string response = this.ServerConnection.PostDataAsync(routeName, data).Result;
                    // convert response to json object
                    this.responseData = JsonConvert.DeserializeObject<ResponseData>(response);
                    if (this.responseData.code)
                    {
                        // update the AuthConfig file
                        this.authConfig.username = inputData;
                        string json = JsonConvert.SerializeObject(this.authConfig);
                        System.IO.File.WriteAllText(this.AuthConfigPath, json);
                        // Navigate to the setting component
                        this.Invoke((MethodInvoker)delegate {
                            Form form = this.FindForm();
                            Panel panel = (Panel)form.Controls.Find("panelChatMainContainer", true)[0];
                            panel.Controls.Clear();
                            panel.Controls.Add(new Setting_Comp());
                        });
                        // Show success message
                        MessageBox.Show("Username updated successfully");
                    }
                    else {
                        MessageBox.Show("Failed to update username");
                    }
                }
                else if (this._option == "password") {
                    // send request to server to update password
                    string routeName = $"update?authId={this._authId}&option=password";
                    string data = $"{{\"data\": \"{inputData}\"}}";
                    string response = this.ServerConnection.PostDataAsync(routeName, data).Result;
                    // convert response to json object
                    this.responseData = JsonConvert.DeserializeObject<ResponseData>(response);
                    if (this.responseData.code)
                    {
                        // update the AuthConfig file
                        this.authConfig.password = inputData;
                        string json = JsonConvert.SerializeObject(this.authConfig);
                        System.IO.File.WriteAllText(this.AuthConfigPath, json);
                        // Navigate to the setting component
                        this.Invoke((MethodInvoker)delegate {
                            Form form = this.FindForm();
                            Panel panel = (Panel)form.Controls.Find("panelChatMainContainer", true)[0];
                            panel.Controls.Clear();
                            panel.Controls.Add(new Setting_Comp());
                        });
                        // Show success message
                        MessageBox.Show("Password updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update password");
                    }
                }
                else if (this._option == "email")
                {
                    // send request to server to update email
                    string routeName = $"update?authId={this._authId}&option=email";
                    string data = $"{{\"data\": \"{inputData}\"}}";
                    string response = this.ServerConnection.PostDataAsync(routeName, data).Result;
                    // convert response to json object
                    this.responseData = JsonConvert.DeserializeObject<ResponseData>(response);
                    if (this.responseData.code)
                    {
                        // update the AuthConfig file
                        this.authConfig.email = inputData;
                        string json = JsonConvert.SerializeObject(this.authConfig);
                        System.IO.File.WriteAllText(this.AuthConfigPath, json);
                        // Navigate to the setting component
                        this.Invoke((MethodInvoker)delegate {
                            Form form = this.FindForm();
                            Panel panel = (Panel)form.Controls.Find("panelChatMainContainer", true)[0];
                            panel.Controls.Clear();
                            panel.Controls.Add(new Setting_Comp());
                        });
                        // Show success message
                        MessageBox.Show("Email updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update email");
                    }
                }

            });
        }
        // Back button click event
        private void LinkButtonBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Navigate to the setting component
            Form form = this.FindForm();
            Panel panel = (Panel)form.Controls.Find("panelChatMainContainer", true)[0];
            panel.Controls.Clear();
            panel.Controls.Add(new Setting_Comp());
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
    }
}
