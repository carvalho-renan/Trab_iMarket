using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iMarket
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Tela_06 : ContentPage
	{
        public Tela_06 ()
		{
			InitializeComponent ();
		}
        public void Voltarpaginicial(object sender, EventArgs args)
        {
            App.Current.MainPage = new iMarket.MainPage();
        }
        private string senhagenrenteA = "123";
        private string senhagenrenteB = "456";
        private string senhagenrenteC = "789";
        private void Login(object sender, EventArgs args)
        {
            if (string.IsNullOrEmpty(codigo.Text))
            {
                DisplayAlert("Alerta!", "Digite uma Senha Válida!", "OK");
            }
            else if(codigo.Text == senhagenrenteA)
            {
                App.Current.MainPage = new iMarket.Tela_07();
            }
            else if (codigo.Text == senhagenrenteB)
            {
                App.Current.MainPage = new iMarket.Tela_08();
            }
            else if (codigo.Text == senhagenrenteC)
            {
                App.Current.MainPage = new iMarket.Tela_09();
            }
            else
            {
                DisplayAlert("Alerta!", "Senha Inválida!", "OK");
            }
        }
    }
}