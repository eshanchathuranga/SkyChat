using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyChat.Lib.Components.MainForm
{
    public partial class Incomming_Message_Comp : UserControl
    {
        public Incomming_Message_Comp(string message, string timeStamp)
        {
            InitializeComponent();
            lableIncomeMessage.Text = message;
            lableTimeStamp.Text = timeStamp;
        }
    }
}
