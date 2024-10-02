using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SkyChat.Lib.Modules
{
    internal class ImgbbUpload
    {
        // upload image to imgbb.com
        public async Task<string> UploadImage(string _id, string imageFile)
        {
            string responseData = string.Empty;
            try
            {
                HttpClient httpClient = new HttpClient();
                string url = "https://api.imgbb.com/1/upload";
                httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer c2765cc313c6ef190a9ecb935a53440d");
                //httpClient.DefaultRequestHeaders.Add("Content-Type", "application/x-www-form-urlencoded")
                var formData = new MultipartFormDataContent();
                formData.Add(new StringContent("image"), "image");
                formData.Add(new StringContent("c2765cc313c6ef190a9ecb935a53440d"), "key");
                using (var fileContent = new StreamContent(File.OpenRead(imageFile)))
                {
                    formData.Add(fileContent, "image", $"{_id}.jpg"); // image name

                    var response = await httpClient.PostAsync(url, formData);
                    var responseContent = await response.Content.ReadAsStringAsync();
                    responseData = responseContent;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return responseData;
        }
    }
}
