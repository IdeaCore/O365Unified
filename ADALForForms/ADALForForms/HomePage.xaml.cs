using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Xamarin.Forms;

namespace ADALForForms
{
    public partial class HomePage : ContentPage
    {
        public static string clientId = "<client id>";
        public static string authority = "https://login.microsoftonline.com/common";
        public static string returnUri = "<redirect uri>";
        private const string graphResourceUri = "https://graph.microsoft.com";
        public static string graphApiVersion = "2013-11-08";

        public HomePage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            App.AuthenticationResult = await DependencyService.Get<IAuthenticator>()
                .Authenticate(authority, graphResourceUri, clientId, returnUri);
            var userName = App.AuthenticationResult.UserInfo.GivenName + " " 
                + App.AuthenticationResult.UserInfo.FamilyName;
            await DisplayAlert("Token", userName, "Ok", "Cancel");
            var tabbedPage = new TabbedPage() { Title = "O365 Sample"};
            tabbedPage.Children.Add(new MePage() {Title = "About Me"});
            tabbedPage.Children.Add(new FilesPage() {Title = "My Files"});
            await Navigation.PushAsync(tabbedPage);
        }
    }
}
