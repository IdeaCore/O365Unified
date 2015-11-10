using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using ADALForForms.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;

namespace ADALForForms
{
	public partial class FilesPage : ContentPage
	{
		public FilesPage ()
		{
			InitializeComponent ();
            Appearing += FilesPageAppearing;
		}

        private async void FilesPageAppearing(object sender, EventArgs e)
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", App.AuthenticationResult.AccessToken);
            var meData = await client.GetStringAsync("https://graph.microsoft.com/beta/me/drive/root/children");
            var data = JsonConvert.DeserializeObject<FilesModel>(meData);
            var files = from file in data.Value
                //where file.Type.ToLower() == "file"
                select file.Name;
            this.FileList.ItemsSource = files.ToList();
        }
    }
}

