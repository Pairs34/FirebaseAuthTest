using System;
using System.Threading.Tasks;
using Firebase.Auth;
using FirebaseAuthTest.Interfaces;
using FirebaseAuthTest.iOS.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(IOSFbAuth))]
namespace FirebaseAuthTest.iOS.Interfaces
{
    public class IOSFbAuth : IFBAuth
    {
        public async Task<string> LoginWithEP(string E, string P)
        {
            var auth = await Auth.DefaultInstance.SignInWithPasswordAsync(E, P);
            return auth.User.Email;

        }

        public async Task<string> RegisterWithEP(string E, string P)
        {
            var auth = await Auth.DefaultInstance.CreateUserAsync(E,P);
            return auth.User.Email;
        }
    }
}
