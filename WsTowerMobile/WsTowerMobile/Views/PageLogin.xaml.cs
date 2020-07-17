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
    public partial class PageLogin : ContentPage
    {
        public PageLogin()
        {
            InitializeComponent();
           // NavigationPage.SetHasNavigationBar(this, false);
        }

        public void botaoEntrar(object sender, EventArgs args)
        {
            Navigation.PushAsync (new PagePrincipal());
        }

        public void botaoCadastrese(object sender, EventArgs e)
        {
             Navigation.PushAsync (new PageCadastro());
        }
    }
}