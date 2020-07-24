using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace WsTowerMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePrincipal : IMasterDetailPageController
    {
        public PagePrincipal()
        {
            InitializeComponent();
            Detail = new NavigationPage(new PageNossaHist());
            NavigationPage.SetHasNavigationBar(this, false);
            IsPresented = false;
        }

        async void botaoContato (object sender, EventArgs args)
        {
            await DisplayAlert("Contato", "Email: WsTower@gmail.com", "OK");
        }
        async void botaoLocalizacao(object sender, EventArgs args)
        {
            await DisplayAlert("Localização", "Brazil, Sp, Av. São João nº:99999", "OK");
        }

        async void botaoSair(object sender, EventArgs args)
        {
            bool answer = await DisplayAlert("Atenção", "Deseja sair do aplicativo?", "Sim", "Não");
            if( answer == true)
            {
                Thread.CurrentThread.Abort();
            }
        }

        public void botaoProx(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new PageProximosEvent());
            NavigationPage.SetHasNavigationBar(this, false);
            IsPresented = false;
        }
        public void botaoNossaHist(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new PageNossaHist());
            NavigationPage.SetHasNavigationBar(this, false);
            IsPresented = false;
        }

        public void botaoAnt(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new PageEventPassados());
            NavigationPage.SetHasNavigationBar(this, false);
            IsPresented = false;
        }

    }
}