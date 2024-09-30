using SkyChat.Lib.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SkyChat.Lib.Components.IndexForm.Create_Acount_Comp;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SkyChat.Lib.Components.IndexForm
{
    public partial class Login_Account_Comp : UserControl
    {
        // Define a object og Get File Path
        GetFilePath getFilePath;
        // Define a AuthConfig File Path
        private string AuthConfigPath;
        // Create a Instens of ServerConnection
        ServerConnection ServerConnection;
        // Create a object of ResponseData
        ResponseData responseData;
        // Create a object of AuthConfig
        AuthConfig authConfig;
        public Login_Account_Comp()
        {
            InitializeComponent();
            // Create a object og get file path
            this.getFilePath = new GetFilePath();
            // Get File path
            this.AuthConfigPath = getFilePath.GetConfigFilePath("AuthConfig.json");
            ServerConnection = new ServerConnection();
            // Read the AuthConfig file
            string json = System.IO.File.ReadAllText(AuthConfigPath);
            authConfig = JsonConvert.DeserializeObject<AuthConfig>(json);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form IindexForm = this.FindForm();
            Panel indexPanel = (Panel)IindexForm.Controls.Find("panelIndexContainer", true)[0];
            indexPanel.Controls.Clear();
            Create_Acount_Comp create_Acount_Comp = new Create_Acount_Comp();
            create_Acount_Comp.Location = new Point(0, 0);
            indexPanel.Controls.Add(create_Acount_Comp);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = this.FindForm();
            Panel indexPanel = (Panel)form.Controls.Find("panelIndexContainer", true)[0];
            indexPanel.Controls.Clear();
            Forgot_Password_Comp forgot_Password_Comp = new Forgot_Password_Comp();
            forgot_Password_Comp.Location = new Point(0, 0);
            indexPanel.Controls.Add(forgot_Password_Comp);
        }

        private void Login_Account_Comp_Load(object sender, EventArgs e)
        {

        }

        private async void btnSubmitLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmailInputLogin.Text;
            string password = txtPasswordInputLogin.Text;

            if (!string.IsNullOrEmpty(email))
            {
                if (!string.IsNullOrEmpty(password))
                {
                    // Login the user
                     string data = $@"{{""type"":""login"",""email"": ""{email}"", ""password"": ""{password}""}}";
                    string response = await ServerConnection.PostDataAsync("auth", data);
                    responseData = JsonConvert.DeserializeObject<ResponseData>(response);

                    if (responseData.code)
                    {

                    

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
                    else
                    {
                        MessageBox.Show(responseData.message);
                    }




                }
                else
                {
                    txtPasswordInputLogin.PlaceholderForeColor = Color.Red;
                    txtPasswordInputLogin.PlaceholderText = "Password is required";
                }

            }
            else
            {
                txtEmailInputLogin.PlaceholderForeColor = Color.Red;
                txtEmailInputLogin.PlaceholderText = "Email is required";
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
    }
}
