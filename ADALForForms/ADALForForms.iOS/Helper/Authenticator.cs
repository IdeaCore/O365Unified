using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(ADALForForms.iOS.Helper.Authenticator))]
namespace ADALForForms.iOS.Helper
{
    class Authenticator : IAuthenticator
    {
        public async System.Threading.Tasks.Task<AuthenticationResult> Authenticate(string authority, string resource, string clientId, string returnUri)
        {
            var authContext = new AuthenticationContext(authority);
            if (authContext.TokenCache.ReadItems().Any())
                authContext = new AuthenticationContext(authContext.TokenCache.ReadItems().First().Authority);
            var authResult = await authContext.AcquireTokenAsync(resource, clientId, new Uri(returnUri),
                new PlatformParameters(UIApplication.SharedApplication.KeyWindow.RootViewController));
            return authResult;
        }
    }
}