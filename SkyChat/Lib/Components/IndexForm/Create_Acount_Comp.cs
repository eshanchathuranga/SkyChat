using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkyChat.Lib.Modules;
using Newtonsoft.Json;

namespace SkyChat.Lib.Components.IndexForm
{
    public partial class Create_Acount_Comp : UserControl
    {
        // Define a AuthConfig File Path
        private string AuthConfigPath = @"C:\\Users\\User\\Desktop\\Last_Project\\SkyChat\\SkyChat\\Lib\\Config\\AuthConfig.json";
        // Create a Instens of ServerConnection
        ServerConnection ServerConnection;
        // Create a object of ResponseData
        ResponseData responseData;
        // Create a object of AuthConfig
        AuthConfig authConfig;

        public Create_Acount_Comp()
        {
            InitializeComponent();
            ServerConnection = new ServerConnection();
            // Read the AuthConfig file
            string json = System.IO.File.ReadAllText(AuthConfigPath);
            authConfig = JsonConvert.DeserializeObject<AuthConfig>(json);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form indexForm = this.FindForm();
            Panel indexPanel = (Panel)indexForm.Controls.Find("panelIndexContainer", true)[0];
            indexPanel.Controls.Clear();
            Login_Account_Comp login_Account_Comp = new Login_Account_Comp();
            login_Account_Comp.Location = new Point(0, 0);
            indexPanel.Controls.Add(login_Account_Comp);
        }

        private async void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsernameInputCreate.Text;
            string password = txtPasswordInputCreate.Text;
            string email = txtEmailInputCreate.Text;

            // Check if the email, username and password are valid
            if (isEmailValid(email) && isUsernameValid(username) && isPasswordValid(password))
            {
                string data = $@"{{""type"":""check"",""username"": ""{username}"", ""email"": ""{email}"", ""password"": ""{password}""}}";
                // Check if the email is already in use
                string response =  await ServerConnection.PostDataAsync("auth",data);
                // Deserialize the response
                responseData = JsonConvert.DeserializeObject<ResponseData>(response);
                if (responseData.code)
                {
                    // Create the account
                    string dataSignup = $@"{{""type"":""signup"",""username"": ""{username}"", ""email"": ""{email}"", ""password"": ""{password}""}}";
                    response = await ServerConnection.PostDataAsync("auth", dataSignup);
                    responseData = JsonConvert.DeserializeObject<ResponseData>(response);
                    // user data to json
                    var dataAuthUser = responseData.userData;
                    var dataAuthuserJson = JsonConvert.SerializeObject(dataAuthUser);
                    // Save Auth data to config file
                    System.IO.File.WriteAllText(AuthConfigPath, dataAuthuserJson);
                    // Read the AuthConfig file
                    string json = System.IO.File.ReadAllText(AuthConfigPath);
                    authConfig = JsonConvert.DeserializeObject<AuthConfig>(json);
                    // Redirect to the  Enter Otp Form
                    Form indexForm = this.FindForm();
                    Panel indexPanel = (Panel)indexForm.Controls.Find("panelIndexContainer", true)[0];
                    indexPanel.Controls.Clear();
                    Enter_Otp_Comp enter_Otp_Comp = new Enter_Otp_Comp(authConfig.email, authConfig.username, authConfig._id);
                    enter_Otp_Comp.Location = new Point(0, 0);
                    indexPanel.Controls.Add(enter_Otp_Comp);
                }
            }
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

        private bool isEmailValid(string email)
        {
            if (email.Contains("@") && email.Contains("."))
            {
                return true;
            }
            else
            {
                txtEmailInputCreate.Clear();
                txtEmailInputCreate.PlaceholderForeColor = Color.Red;
                txtEmailInputCreate.PlaceholderText = "Invalid Email";
                return false;
            }
        }
        private bool isUsernameValid(string username)
        {
            if (username.Length > 3)
            {
                return true;
            }
            else
            {
                txtUsernameInputCreate.Clear();
                txtUsernameInputCreate.PlaceholderForeColor = Color.Red;
                txtUsernameInputCreate.PlaceholderText = "Invalid Username";
                return false;
            }
        }
        private bool isPasswordValid(string password)
        {
            if (password.Length > 4)
            {
                return true;
            }
            else
            {
                txtPasswordInputCreate.Clear();
                txtPasswordInputCreate.PlaceholderForeColor = Color.Red;
                txtPasswordInputCreate.PlaceholderText = "Invalid Password";
                return false;
            }
        }
    }
}
