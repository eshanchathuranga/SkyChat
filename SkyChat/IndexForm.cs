using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkyChat.Lib.Components;
using SkyChat.Lib.Components.IndexForm;
using Newtonsoft.Json;
using SkyChat.Lib.Modules;

namespace SkyChat
{
    public partial class IndexForm : Form
    {
        // Define a object og Get File Path
        GetFilePath getFilePath;
        // Define a AuthConfig File Path
        private string AuthConfigPath;
        // Create a object of AuthConfig
        AuthConfig authConfig;
        public IndexForm()
        {                    
             //InitializeComponent();
            // Create a object og get file path
            this.getFilePath = new GetFilePath();
            // Get File path
            this.AuthConfigPath = getFilePath.GetConfigFilePath("AuthConfig.json");
            // Read the AuthConfig file
            string json = System.IO.File.ReadAllText(AuthConfigPath);
            authConfig = JsonConvert.DeserializeObject<AuthConfig>(json);
            // Check already login or not
            if (authConfig._id != null)
            {
                MainForm mainForm = new MainForm();
                //mainForm.Show();
                //Task.Run(() =>
                //{
                //    if (this.InvokeRequired)
                //    {
                //        this.BeginInvoke((MethodInvoker)delegate
                //        {
                //            this.Hide();
                //        });
                //    }
                //    else
                //    {
                //        this.Hide();
                //    }
                //});
                Application.Run(mainForm);
                this.Close();
            }
            else
            {
                InitializeComponent();
                // Set the default user control to the index page
                Login_Account_Comp login_Account_Comp = new Login_Account_Comp();
                login_Account_Comp.Location = new Point(0, 0);
                panelIndexContainer.Controls.Add(login_Account_Comp);
            }

        }
        private void IndexForm_Load_1(object sender, EventArgs e)
        {

        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelIndexContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIndexClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        
    }
}
