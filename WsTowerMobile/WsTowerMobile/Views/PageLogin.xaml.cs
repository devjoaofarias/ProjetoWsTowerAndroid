using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
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
          NavigationPage.SetHasNavigationBar(this, false);
        }

        async void botaoEntrar(object sender, EventArgs args)
        {
            var usuarios = await App.Database.GetUserAsync();

            var usuario = usuarios.Where(p => p.Email == enterEmail.Text && p.Senha == enterSenha.Text).FirstOrDefault();

            if (usuario != null)
            {
                    await Navigation.PushAsync(new PagePrincipal());
            } else
            {
                    await DisplayAlert("Erro", "O usuário ou senha estão incorretos", "Ok");
            }
            

        }
            

        public void botaoCadastrese(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageCadastro());
        }
    }
}