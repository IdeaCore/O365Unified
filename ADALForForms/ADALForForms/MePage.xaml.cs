using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using ADALForForms.Model;
using Microsoft.OData.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;

namespace ADALForForms
{
	public partial class MePage : ContentPage
	{
        public MePage ()
		{
			InitializeComponent ();
		    this.Appearing += MePageAppearing;
		}

        private async void MePageAppearing(object sender, EventArgs e)
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", App.AuthenticationResult.AccessToken);
            var meData = await client.GetStringAsync("https://graph.microsoft.com/beta/me");
            var userData = JsonConvert.DeserializeObject<UserModel>(meData);
            this.DisplayName.Text = userData.DisplayName;
            this.Mail.Text = userData.Mail;
            this.Country.Text = userData.Country;
        }
    }
}

