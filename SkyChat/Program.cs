using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyChat
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IndexForm indexForm = new IndexForm();
            if (indexForm.IsDisposed)
            {
                Application.Exit();
            }
            else
            {
                Application.Run(indexForm);
            }
        }
    }
}
