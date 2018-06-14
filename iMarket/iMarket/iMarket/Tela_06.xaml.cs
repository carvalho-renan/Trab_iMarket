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
        public void voltarpaginicial(object sender, EventArgs args)
        {
            App.Current.MainPage = new iMarket.MainPage();
        }
    }
}