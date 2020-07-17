using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WsTowerMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageSplash : ContentPage
    {
        public bool IsPlaying { get; set; }
        public PageSplash()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = this;
            OnPropertyChanged(nameof(IsPlaying));
            Navegacao();
        }

        private async void Navegacao()
        {
            await Task.Delay(14000);
            App.Current.MainPage = new NavigationPage(new PageLogin());
        }
    }
}