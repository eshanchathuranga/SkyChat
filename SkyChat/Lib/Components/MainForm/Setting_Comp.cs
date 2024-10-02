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
using Guna.UI2.WinForms;
using System.Net;

namespace SkyChat.Lib.Components.MainForm
{
    public partial class Setting_Comp : UserControl
    {
        // Define a object og Get File Path
        GetFilePath getFilePath;
        // Crate a object of ResponseData
        ResponseData responseData;
        // Create a object of AuthConfig
        AuthConfig authConfig;
        // Create a object of ServerConnection
        ServerConnection ServerConnection;
        // Create a object of ImgbbUpload
        ImgbbUpload imgbbUpload;
        // Create a object of Imagbb data
        ImgBBResponse imgBBResponse;
        // Define a AuthConfig File Path
        private string AuthConfigPath;
        // Create a object of Auth
        private string _authId;
        private string _authUsername;
        private string _authEmail;
        // Crate a object of Modification type
        private string modificationType;
        // User Control Constructor
        public Setting_Comp()
        {
            InitializeComponent();
            // Create a new objet of ServerConnection
            this.ServerConnection = new ServerConnection();
            // Create a new objet of ImgbbUpload
            this.imgbbUpload = new ImgbbUpload();
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
        // Profile Picture Click Event
        private void userImage_Click(object sender, EventArgs e)
        {
            string profilepicPath;
            // Open the file dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                profilepicPath = openFileDialog.FileName;
                // Upload the Image to Imdgbb.com
                Task.Run(() =>
                {
                    // Upload the image to imgbb.com
                    string response = this.imgbbUpload.UploadImage(this._authId, profilepicPath).Result;
                    // Convert the response to json object
                    this.imgBBResponse = JsonConvert.DeserializeObject<ImgBBResponse>(response);
                    // Update the AuthConfig file
                    authConfig.picUrl = this.imgBBResponse.data.url;
                    string json = JsonConvert.SerializeObject(authConfig);
                    System.IO.File.WriteAllText(AuthConfigPath, json);
                    // Show success message
                    MessageBox.Show("Profile Picture updated successfully");
                    // Update the profile picture
                    this.Invoke((MethodInvoker)delegate
                    {
                        using (var webClient = new WebClient())
                        {
                            byte[] imageBytes = webClient.DownloadData(authConfig.picUrl);
                            using (var ms = new MemoryStream(imageBytes))
                            {
                                userImage.Image = System.Drawing.Image.FromStream(ms);
                            }
                        }
                    });
                });

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
        // Create a class to store the Imgbbresponse data
        public class ImgBBResponse
        {
            public Data data { get; set; }
        }
        // Create a class to store the Imgbb data
        public class Data
        {
            public string url { get; set; }
        }
    }
}
