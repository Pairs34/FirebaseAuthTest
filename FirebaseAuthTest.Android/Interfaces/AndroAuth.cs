using System;
using System.Threading.Tasks;
using FirebaseAuthTest.Droid.Interfaces;
using FirebaseAuthTest.Interfaces;
using Xamarin.Forms;
using Firebase.Auth;

[assembly: Dependency(typeof(AndroAuth))]
namespace FirebaseAuthTest.Droid.Interfaces
{
    public class AndroAuth : IFBAuth
    {
        public async Task<string> LoginWithEP(string E, string P)
        {
            var auth = await FirebaseAuth.Instance.SignInWithEmailAndPasswordAsync(E, P);
            return auth.User.Email;
        }

        public async Task<string> RegisterWithEP(string E, string P)
        {
            var auth = await FirebaseAuth.Instance.CreateUserWithEmailAndPasswordAsync(E, P);
            return auth.User.Email;
        }
    }
}
