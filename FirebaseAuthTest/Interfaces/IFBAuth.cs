using System;
using System.Threading.Tasks;

namespace FirebaseAuthTest.Interfaces
{
    public interface IFBAuth
    {
        Task<string> LoginWithEP(string E,string P);
        Task<string> RegisterWithEP(string E,string P);
    }
}
