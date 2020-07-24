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
            await DisplayAlert("Contato", "Telefone: (11) 2020-5050" +
                "                        Email: WsTower@gmail.com", "OK");
        }
        async void botaoLocalizacao(object sender, EventArgs args)
        {
            await DisplayAlert("Localização", "Brazil, Sp, Av. São João nº:99999", "OK");
        }

        public void botaoSair(object sender, EventArgs args)
        {
            Thread.CurrentThread.Abort();
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