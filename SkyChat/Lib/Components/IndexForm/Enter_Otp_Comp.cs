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
using Newtonsoft.Json;
using static SkyChat.MainForm;

namespace SkyChat.Lib.Components.IndexForm
{
    public partial class Enter_Otp_Comp : UserControl
    {
        ServerConnection ServerConnection;
        // Create a object of ResponseData
        ResponseData responseData;

        private string _email;
        private string _username;
        private string _authId;
        private int _otp;
        public Enter_Otp_Comp(string email, string username, string authId )
        {
            InitializeComponent();
            this._email = email;
            this._username = username;
            this._authId = authId;
            this.ServerConnection = new ServerConnection();
            linkLabel2.Enabled = false;

            Task.Run(() =>
            {
                // Send the OTP to the server
                string rout = $"sendotp?authId={this._authId}";
                string data = $@"{{""email"": ""{this._email}"", ""username"": ""{this._username}"" }}";
                string response = ServerConnection.PostDataAsync(rout, data).Result;
                // Deserialize the response
                responseData = JsonConvert.DeserializeObject<ResponseData>(response);
                this._otp = responseData.otp;
                // Check if the OTP was sent
                if (responseData.code)
                {
                    // Wait for 10 seconds
                    System.Threading.Thread.Sleep(10000);
                    this.Invoke((MethodInvoker)delegate
                    {
                        linkLabel2.Enabled = true;
                    });
                }
            });
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form IindexForm = this.FindForm();
            Panel indexPanel = (Panel)IindexForm.Controls.Find("panelIndexContainer", true)[0];
            indexPanel.Controls.Clear();
            Login_Account_Comp login_Account_Comp = new Login_Account_Comp();
            login_Account_Comp.Location = new Point(0, 0);
            indexPanel.Controls.Add(login_Account_Comp);
        }

        private void btnOtpSubmit_Click(object sender, EventArgs e)
        {
            int otp = int.Parse(txtOtpInput.Text);

            if (otp == this._otp)
            {
                Form form = this.FindForm();
                SkyChat.MainForm mainForm = new SkyChat.MainForm();
                mainForm.Show();
                form.Hide();
            }



        }
    
        // Create a class to store the response data
        public class ResponseData
        {
            public string message { get; set; }
            public int otp { get; set; }
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Task.Run(() =>
            {
                // Send the OTP to the server
                string rout = $"sendotp?authId={this._authId}";
                string data = $@"{{""email"": ""{this._email}"", ""username"": ""{this._username}"" }}";
                string response = ServerConnection.PostDataAsync(rout, data).Result;
                // Deserialize the response
                responseData = JsonConvert.DeserializeObject<ResponseData>(response);
                this._otp = responseData.otp;
                // Check if the OTP was sent
                if (responseData.code)
                {
                    // Wait for 10 seconds
                    System.Threading.Thread.Sleep(10000);
                    linkLabel2.Enabled = true;
                }
            });

        }
    }
}
