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
using System.IO;
using MongoDB.Bson;


namespace SkyChat.Lib.Components.MainForm
{
    public partial class User_Lable_Comp : UserControl
    {
        private string MessagePositionPath = @"C:\Users\User\Desktop\Last_Project\SkyChat\SkyChat\Lib\Config\MessagePosition.json";
        private string _authId;
        private string _userid;
        private string _username;
        private string _email;

        private string _CollectionName;

        // Create a object of Message Position
        MessagePosition messagePosition;

        DatabaseConnection databaseConnection;
        public  User_Lable_Comp(string authId, string userid, string username, string email)
        {
            InitializeComponent();
            databaseConnection = new DatabaseConnection();
            this.Name = userid;
            this._userid = userid;
            this._authId = authId;
            this._username = username;
            this._email = email;
            lableUsername.Text = username;
            // Get Conversation Collection Name
            this._CollectionName = GetMessageDatabase(this._authId, this._userid);
                // Update the last message in last message label
                Task.Run(() =>
                {

                    if (this._CollectionName != null)
                    {
                        BsonDocument lastMessage = databaseConnection.GetLastUpdatedDocument("conversations", this._CollectionName);
                        if (lastMessage != null)
                        {
                            string message = lastMessage["message"].ToString();                          
                            this.Invoke((MethodInvoker)delegate
                            {
                                this.lableLastMsg.Text = message;

                            });

                        }
                    }

                });
                
            
        }

        // Load chat container to main Panel
        private void imgUser_Click(object sender, EventArgs e)
        {
            // Reset the Unread Messages
            this.lableLastMsg.ForeColor = Color.FromArgb(192, 192, 192, 192);
            // Read the message position and reset it
            string json = System.IO.File.ReadAllText(MessagePositionPath);
            this.messagePosition = JsonConvert.DeserializeObject<MessagePosition>(json);
            messagePosition.location = 0;
            string jsonMessage = JsonConvert.SerializeObject(this.messagePosition);
            File.WriteAllText(MessagePositionPath, jsonMessage);

            // Open the chat with the user
            Form mainForm = this.FindForm();
            Panel mainPanel = (Panel)mainForm.Controls.Find("panelChatMainContainer", true)[0];
            mainPanel.Controls.Clear();
            Chat_Container_Comp chat_Container_Comp = new Chat_Container_Comp(this._authId, this._userid);
            chat_Container_Comp.Location = new Point(0, 0);
            mainPanel.Controls.Add(chat_Container_Comp);

            // Set the user header
            Panel hesaderPanel = (Panel)mainForm.Controls.Find("panelUserHeader", true)[0];
            hesaderPanel.Controls.Clear();
            User_Header_Comp user_Header_Comp = new User_Header_Comp(this._username, this._email, this._userid);
            user_Header_Comp.Location = new Point(0, 0);
            hesaderPanel.Controls.Add(user_Header_Comp);


        }

        // Get the conversation collection name
        private string GetMessageDatabase(string authId, string userId)
        {
            string collectionOne = $"{authId}_{userId}";
            string collectionTwo = $"{userId}_{authId}";

                bool result = databaseConnection.CollectionExists("conversations", collectionOne);
                if (result)
                {
                    return collectionOne;                
                }
                else
                {
                    bool result1 = databaseConnection.CollectionExists("conversations", collectionTwo);
                    if (result1)
                    {
                        return collectionTwo;
                    }
                    else
                    {
                        return null;
                    }
                }

        }

        // Wait for the collection to change and update the last message label
        private void User_Lable_Comp_Load(object sender, EventArgs e)
        {
            // Wait for the collection to change and update the last message label
            Task.Run(() =>
            {
                while (true)
                {
                    if (this._CollectionName != null)
                    {
                        // Wait for the collection to change
                        bool result = databaseConnection.WaitForChangeCollection("conversations", this._CollectionName);
                        if (result)
                        {
                            // Get the last message from the collection
                            BsonDocument lastMessage = databaseConnection.GetLastUpdatedDocument("conversations", this._CollectionName);
                            if (lastMessage != null)
                            {
                                string message = lastMessage["message"].ToString();
                                UserControl mainPanel = GetContainer();
                                // Notify the user if the chat is not open
                                if (mainPanel == null)
                                {
                                    NotifyIcon notifyIcon = new NotifyIcon();
                                    notifyIcon.Visible = true;
                                    notifyIcon.Icon = new System.Drawing.Icon(@"C:\Users\User\Desktop\Last_Project\SkyChat\SkyChat\Lib\Assest\Icons\Form.ico");
                                    notifyIcon.ShowBalloonTip(300, this._username, message, ToolTipIcon.None);
                                }
                                // Update the last message label
                                this.Invoke((MethodInvoker)delegate
                                    {
                                        this.lableLastMsg.ForeColor = Color.FromArgb(192, 192, 192, 192);
                                        if (mainPanel != null)
                                        {
                                            if (mainPanel.Name == this._userid)
                                            {
                                                this.lableLastMsg.Text = message;
                                            }
                                        }
                                        else
                                        {
                                            this.lableLastMsg.Text = message;
                                            this.lableLastMsg.ForeColor = Color.White;
                                            
                                        }
                                    });
                                

                            }
                        }
                    }
                }
            });
        }
        // Get the chat container
        private UserControl GetContainer()
        {
            UserControl userControl = null;
            Form mainform = this.FindForm();
            Panel mainPanel = (Panel)mainform.Controls.Find("panelChatMainContainer", true)[0];
            foreach (Control control in mainPanel.Controls)
            {
                if (control is Chat_Container_Comp)
                {
                    userControl = (Chat_Container_Comp)control;
                }
            }
            return userControl;
        }
        // Create a class to store the message position
        public class MessagePosition
        {
            public int location { get; set; }
        }
    }
}
