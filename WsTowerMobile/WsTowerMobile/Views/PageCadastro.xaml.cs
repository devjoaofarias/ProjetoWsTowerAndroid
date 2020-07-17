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
    public partial class PageCadastro : ContentPage
    {
        public PageCadastro()
        {
            InitializeComponent();
        }

        public void botaoLogin(object sender, EventArgs args)
        {
            Navigation.PopAsync();
        }

        public void botaoCadastrar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PagePrincipal());
        }
    }
}