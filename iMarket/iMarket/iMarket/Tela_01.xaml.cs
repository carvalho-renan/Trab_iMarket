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
	public partial class Tela_01 : ContentPage
	{
		public Tela_01 ()
		{
			InitializeComponent ();
		}
        public void Voltarpaginicial(object sender, EventArgs args)
        {
            App.Current.MainPage = new iMarket.MainPage();
        }
        public void Mudarparapag02(object sender, EventArgs args)
        {
            App.Current.MainPage = new iMarket.Tela_02();
        }
        public void Mudarparapag03(object sender, EventArgs args)
        {
            App.Current.MainPage = new iMarket.Tela_03();
        }
        public void Mudarparapag04(object sender, EventArgs args)
        {
            App.Current.MainPage = new iMarket.Tela_04();
        }
    }
}