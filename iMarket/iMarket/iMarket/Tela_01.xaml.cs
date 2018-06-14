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
        public void voltarpaginicial(object sender, EventArgs args)
        {
            App.Current.MainPage = new iMarket.MainPage();
        }
        public void mudarparapag02(object sender, EventArgs args)
        {
            App.Current.MainPage = new iMarket.Tela_02();
        }
        public void mudarparapag03(object sender, EventArgs args)
        {
            App.Current.MainPage = new iMarket.Tela_03();
        }
        public void mudarparapag04(object sender, EventArgs args)
        {
            App.Current.MainPage = new iMarket.Tela_04();
        }
    }
}