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
    public partial class PageCadastro : ContentPage
    {
        public PageCadastro()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetUserAsync();
        }

        public void botaoLogin(object sender, EventArgs args)
        {
            Navigation.PopAsync();
        }

        async void botaoCadastrar(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(EnterUsuario.Text) && !String.IsNullOrWhiteSpace(EnterEmail.Text) && !String.IsNullOrWhiteSpace(EnterSenha.Text) && !String.IsNullOrWhiteSpace(EnterSenhaConfirm.Text))
            {
                await App.Database.SaveUserAsync(new Usuario
                {   
                    User = EnterUsuario.Text,
                    Email = EnterEmail.Text,
                    Senha = EnterSenha.Text
                }); ;

                EnterUsuario.Text = EnterEmail.Text = EnterSenha.Text = EnterSenhaConfirm.Text = string.Empty;

                listView.ItemsSource = await App.Database.GetUserAsync();

                await DisplayAlert("Cadastrado", "Usuário cadastrado com sucesso!", "Ok");
            }
            {
                await DisplayAlert("Erro", "Ocorreu algum erro, ferifique novamente", "Ok");
            }
        }
    }
}