using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppPhoto.Page;

namespace AppPhoto
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PINPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
