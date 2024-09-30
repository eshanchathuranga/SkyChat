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
using MongoDB.Bson;
using Newtonsoft.Json;
using System.IO;

namespace SkyChat.Lib.Components.MainForm
{
    public partial class Chat_Container_Comp : UserControl
    {

        private string MessagePositionPath = @"C:\Users\User\Desktop\Last_Project\SkyChat\SkyChat\Lib\Config\MessagePosition.json";
        // Create a object of Message Position
        MessagePosition messagePosition;
        private string _authId;
        private string _userId;
        DatabaseConnection databaseConnection;
        private string _CollectionName;

        public Chat_Container_Comp(string authId, string userId)
        {
            InitializeComponent();
            this.Name = userId;
            this._authId = authId;
            this._userId = userId;
            databaseConnection = new DatabaseConnection();

            // Get Conversation Collection Name
            this._CollectionName = GetMessageDatabase(this._authId, this._userId);
           
        }

        private void Chat_Container_Comp_Load(object sender, EventArgs e)
        {
            // Update the New incomming Message
            Task.Run(() =>
            {
                while (true)
                {
                    if (this._CollectionName != null)
                    {
                        bool result = databaseConnection.WaitForChangeCollection("conversations", this._CollectionName);
                        if (result)
                        {
                            BsonDocument lastMessage = databaseConnection.GetLastUpdatedDocument("conversations", this._CollectionName);
                            if (lastMessage != null)
                            {
                                string SenderId = lastMessage.GetValue("senderId").ToString();
                                string Message = lastMessage.GetValue("message").ToString();
                                string Time = lastMessage.GetValue("time").ToString();
                                string Date = lastMessage.GetValue("date").ToString();
                                if (SenderId == this._userId)
                                {
                                    // Add the Incomming message to the chat container
                                    Incomming_Message_Comp incomMsg = new Incomming_Message_Comp(Message, Time);
                                    incomMsg.Location = new Point(0, MessageLocation());
                                    this.Invoke((MethodInvoker)delegate
                                    {
                                        this.Controls.Add(incomMsg);
                                    });
                                }
                            }
                        }
                    }
                }
            });
            // Load old messages
            Task.Run(() =>
            {
                if (this._CollectionName != null)
                {
                    string result = GetMessageDatabase(this._authId, this._userId);
                    if (result != null)
                    {
                        List<BsonDocument> messages = databaseConnection.GetAllData("conversations", result);
                        if (messages != null)
                        {
                            foreach (BsonDocument message in messages)
                            {
                                string SenderId = message.GetValue("senderId").ToString();
                                string Message = message.GetValue("message").ToString();
                                string Time = message.GetValue("time").ToString();
                                string Date = message.GetValue("date").ToString();

                                if (SenderId == this._userId)
                                {
                                    // Add the Incomming message to the chat container
                                    Incomming_Message_Comp incomMsg = new Incomming_Message_Comp(Message, Time);
                                    incomMsg.Location = new Point(0, MessageLocation());
                                    this.Invoke((MethodInvoker)delegate
                                    {
                                        this.Controls.Add(incomMsg);
                                    });
                                }
                                else
                                {
                                    // Add the message to the chat container
                                    Outgoin_Message_Comp outgoingMessage = new Outgoin_Message_Comp(Message, Time);
                                    outgoingMessage.Location = new Point(0, MessageLocation());
                                    this.Invoke((MethodInvoker)delegate
                                    {
                                        this.Controls.Add(outgoingMessage);
                                    });
                                }
                            }
                        }
                    }
                }

            });


        }

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


        // Create a class to store the message position
        public class MessagePosition
        {
            public int location { get; set; }
        }
    }
}
