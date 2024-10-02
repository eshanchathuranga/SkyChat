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
using SkyChat.Lib.Components;
using Newtonsoft.Json;
using System.Net.Http;
using System.IO;
using SkyChat.Lib.Components.MainForm;

namespace SkyChat
{
    public partial class MainForm : Form
    {
        // Define a object og Get File Path
        GetFilePath getFilePath;
        // Define a AuthConfig File Path
        private string AuthConfigPath;
        private string UsersAccountsPath;
        private string MessagePositionPath;
        // Create a Instens of ServerConnection
        ServerConnection ServerConnection;
        // Create a object of ResponseData
        ResponseData responseData;
        // Create a object of AuthConfig
        AuthConfig authConfig;
        // Create a object of Users Accounts
        UsersAccount usersAccounts;
        // Create a object of Message Position
        MessagePosition messagePosition;
        // Create a Constuctor of User Label Comp Position
        public int countLocationUser { get; set; }

        // main  event
        public MainForm()
        {
            InitializeComponent();
            // Create a object og get file path
            this.getFilePath = new GetFilePath();
            // Get File path
            this.UsersAccountsPath = getFilePath.GetConfigFilePath("UsersAccounts.json");
            this.AuthConfigPath = getFilePath.GetConfigFilePath("AuthConfig.json");
            this.MessagePositionPath = getFilePath.GetConfigFilePath("MessagePosition.json");
            // Create a object of ServerConnection
            ServerConnection = new ServerConnection();
            // Read the AuthConfig file
            string json = System.IO.File.ReadAllText(AuthConfigPath);
            authConfig = JsonConvert.DeserializeObject<AuthConfig>(json);
            string jsonAccounts = System.IO.File.ReadAllText(UsersAccountsPath);
            usersAccounts = JsonConvert.DeserializeObject<UsersAccount>(jsonAccounts);
        }
        // Form Load Event
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Load the users accounts
                Task.Run(() =>
                {
                    foreach (string account in usersAccounts.accounts)
                    {

                        string jsonAccounts = System.IO.File.ReadAllText(UsersAccountsPath);
                        usersAccounts = JsonConvert.DeserializeObject<UsersAccount>(jsonAccounts);
                        string request = $"get?userId={account}";
                        string data = $@"{{""authId"":""{authConfig._id}""}}";
                        string response = ServerConnection.PostDataAsync(request, data).Result;
                        // Deserialize the response
                        responseData = JsonConvert.DeserializeObject<ResponseData>(response);
                        // User lable insert a panelMainUserContainer
                        panelMainUserContainer.Invoke((MethodInvoker)(() =>
                        {
                            User_Lable_Comp user_Lable_Comp = new User_Lable_Comp(authConfig._id, responseData.userData._id, responseData.userData.username, responseData.userData.email, responseData.userData.picUrl);
                            user_Lable_Comp.Location = new Point(0, UserLocation());
                            panelMainUserContainer.Controls.Add(user_Lable_Comp);
                        }));
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }
        // Search for a user
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearchInput.Text;
            if (!string.IsNullOrEmpty(searchName))
            {
                Task.Run(() =>
                {
                    // Send Search Request
                    string query = $"search?searchUserName={searchName}";
                    string data = JsonConvert.SerializeObject(usersAccounts.accounts);
                    string response = ServerConnection.PostDataAsync(query, data).Result;
                    // Deserialize the response
                    responseData = JsonConvert.DeserializeObject<ResponseData>(response);
                    if (responseData.code)
                    {
                        if (responseData.userData._id != authConfig._id)
                        {
                            // User lable insert a panelMainUserContainer
                            panelMainUserContainer.Invoke((MethodInvoker)(() =>
                            {
                                User_Lable_Comp user_Lable_Comp = new User_Lable_Comp(authConfig._id, responseData.userData._id, responseData.userData.username, responseData.userData.email, responseData.userData.picUrl);
                                user_Lable_Comp.Location = new Point(0, UserLocation());
                                panelMainUserContainer.Controls.Add(user_Lable_Comp);
                            }));
                            // Save account to Config file
                            if (usersAccounts.accounts.Contains(responseData.userData.username))
                            {
                                return;
                            }
                            else
                            {
                                if (usersAccounts.accounts != null)
                                {
                                    usersAccounts.accounts.Add(responseData.userData.username);
                                    string writeFile = JsonConvert.SerializeObject(usersAccounts);
                                    System.IO.File.WriteAllText(UsersAccountsPath, writeFile);
                                }
                                else
                                {
                                    usersAccounts.accounts.Remove(null);
                                    usersAccounts.accounts.Add(responseData.userData._id);
                                    string writeFile = JsonConvert.SerializeObject(usersAccounts);
                                    System.IO.File.WriteAllText(UsersAccountsPath, writeFile);
                                }
                            }
                        }
                        else
                        {
                            // User not found
                            txtSearchInput.Invoke((MethodInvoker)(() =>
                            {
                                txtSearchInput.Clear();
                                txtSearchInput.PlaceholderForeColor = Color.Red;
                                txtSearchInput.PlaceholderText = "Cannot insert your account";
                            }));
                        }
                    }
                    else
                    {
                        // User not found
                        txtSearchInput.Invoke((MethodInvoker)(() =>
                        {
                            txtSearchInput.Clear();
                            txtSearchInput.PlaceholderForeColor = Color.Red;
                            txtSearchInput.PlaceholderText = "User not found";
                        }));

                    }
                });
            }
            else
            {
                txtSearchInput.Clear();
                txtSearchInput.PlaceholderForeColor = Color.Red;
                txtSearchInput.PlaceholderText = "Please enter a name";
            }
        }
        private void panelChatMainContainer_Paint(object sender, PaintEventArgs e)
        {

        }
        // Send Button Click Event
        private void btnMessageSend_Click(object sender, EventArgs e)
        {
            string messageInput = txtMessageInput.Text;
            string dateStamp = DateTime.Now.ToString("yyyy-MM-dd");
            string time = DateTime.Now.ToString("HH:mm:ss");

            // Get the Chat container
            UserControl container = GetContainer();
            if (container != null)
            {
                if (!string.IsNullOrEmpty(messageInput))
                {
                    // Send the message
                    Task.Run(() =>
                    {
                        string rout = $"send?fromId={authConfig._id}&toId={container.Name}";
                        string data = $@"{{""senderId"":""{authConfig._id}"", ""message"":""{messageInput}"",""date"":""{dateStamp}"",""time"":""{time}""}}";
                        string response = ServerConnection.PostDataAsync(rout, data).Result;
                        // Deserialize the response
                        MessageResponse messageResponse = JsonConvert.DeserializeObject<MessageResponse>(response);
                        if (messageResponse.code)
                        {
                            // Message lable insert a panelChatMainContainer
                            panelChatMainContainer.Invoke((MethodInvoker)(() =>
                            {
                                Outgoin_Message_Comp outgoing_Message_Comp = new Outgoin_Message_Comp(messageInput, time);
                                outgoing_Message_Comp.Location = new Point(0, MessageLocation());
                                container.Controls.Add(outgoing_Message_Comp);
                                txtMessageInput.Clear();
                            }));
                        }
                        else
                        {
                            txtMessageInput.PlaceholderForeColor = Color.Red;
                            txtMessageInput.PlaceholderText = "Message not sent";
                        }
                    });

                }
                else
                {
                    txtMessageInput.PlaceholderForeColor = Color.Red;
                    txtMessageInput.PlaceholderText = "Message is required";
                }
            }
            else
            {
                lableSelectChat.ForeColor = Color.FromArgb(242, 48, 48, 1);
            }
        }
        // Get Chat container in the panelChatMainContainer
        private UserControl GetContainer()
        {
            UserControl userControl = null;
            foreach (Control control in panelChatMainContainer.Controls)
            {
                if (control is Chat_Container_Comp)
                {
                    userControl = (Chat_Container_Comp)control;
                }
            }
            return userControl;
        }
        // Load Seting Comp event
        private void btnAcountSettings_Click(object sender, EventArgs e)
        {
            Setting_Comp setting_Comp = new Setting_Comp();
            setting_Comp.Location = new Point(0, 0);
            panelChatMainContainer.Controls.Clear();
            panelChatMainContainer.Controls.Add(setting_Comp);
            panalMessageSend.Visible = false;
            panelUserHeader.Controls.Clear();
        }
        // null
        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }
        // User back button event
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panelChatMainContainer.Controls.Clear();
            panelUserHeader.Controls.Clear();
        }
        // Count next location for MessageComp
        private int MessageLocation()
        {
            string json = System.IO.File.ReadAllText(MessagePositionPath);
            this.messagePosition = JsonConvert.DeserializeObject<MessagePosition>(json);
            //int re = 0;
            //int count = this.countLocationMessage;
            //if (count == 0)
            //{
            //    this.countLocationMessage += 33;
            //    re = 0;
            //}
            //else
            //{
            //    count = this.countLocationMessage;
            //    this.countLocationMessage += 33;
            //    re = count;
            //}
            //return re;
            int re = 0;
            int count = this.messagePosition.location;
            if (count == 0)
            {
                this.messagePosition.location += 33;
                string jsonMessage = JsonConvert.SerializeObject(this.messagePosition);
                File.WriteAllText(MessagePositionPath, jsonMessage);
                re = 0;
            }
            else
            {
                count = this.messagePosition.location;
                this.messagePosition.location += 33;
                string jsonMessage = JsonConvert.SerializeObject(this.messagePosition);
                File.WriteAllText(MessagePositionPath, jsonMessage);
                re = count;
            }
            return re;
        }
        // Count next location for UserComp
        private int UserLocation()
        {
            int re = 0;
            int count = this.countLocationUser;
            if (count == 0)
            {
                this.countLocationUser += 65;
                re = 0;
            }
            else
            {
                count = this.countLocationUser;
                this.countLocationUser += 65;
                re = count;
            }
            return re;
        }
        // Create a class to store ther usersAccounts data
        public class UsersAccount
        {
            public List<string> accounts { get; set; }
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
        // Create a class to store the message position
        public class MessagePosition
        {
            public int location { get; set; }
        }
        // Create a class to store the message response
        public class MessageResponse
        {
            public string status { get; set; }
            public bool code { get; set; }
            public string message { get; set; }
            public string conversationId { get; set; }
            public MessageData data { get; set; }
        }
        // create a class to store the message data
        public class MessageData
        {
            public string senderId { get; set; }
            public string message { get; set; }
            public string time { get; set; }
            public string date { get; set; }
        }

    }
}
