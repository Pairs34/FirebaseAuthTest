using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebaseAuthTest.Interfaces;
using Xamarin.Forms;

namespace FirebaseAuthTest
{
    public partial class MainPage : ContentPage
    {
        IFBAuth fBAuth;
        public MainPage()
        {
            InitializeComponent();
        }

        async void btnLogin_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                fBAuth = DependencyService.Get<IFBAuth>();
                string varEmail = email.Text;
                string varPass = pass.Text;
                string response = await fBAuth.LoginWithEP(varEmail, varPass);
                await DisplayAlert("Mail Adress", response, "Kapat");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Kapat");
            }
        }

        async void btnRegister_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                fBAuth = DependencyService.Get<IFBAuth>();
                string varEmail = email.Text;
                string varPass = pass.Text;
                string response = await fBAuth.RegisterWithEP(varEmail, varPass);
                await DisplayAlert("Mail Adress", response, "Kapat");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Kapat");
            }
        }
    }
}
