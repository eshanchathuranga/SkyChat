using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyChat.Lib.Modules
{
    internal class GetFilePath
    {
        // Get Config File Path
        public  string GetConfigFilePath(string fileName)
        {
            string defaultPath = Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 10);
            // go to Lib folder
            string path = defaultPath + @"\\Lib\\Config\\" + fileName;
            return path;

        }
    }
}
