using System;
using WsTowerMobile.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WsTowerMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new PageSplash();
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
