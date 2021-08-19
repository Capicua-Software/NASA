using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using NASA.Views;

namespace NASA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void RegisterCommand(object sender, EventArgs args)
        {
            ((App)Parent).MainPage = new SignUpPage();
        }

        void SignInCommand(object sender, EventArgs args)
        {
            //NavigationPage.SetHasBackButton(this, false);
            //await Navigation.PushAsync(new LoginPage());
            ((App)Parent).MainPage = new LoginPage();
        }



    }
}
