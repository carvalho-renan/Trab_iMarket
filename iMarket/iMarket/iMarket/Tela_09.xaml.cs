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
	public partial class Tela_09 : ContentPage
	{
		public Tela_09 ()
		{
			InitializeComponent ();
		}
        public void voltarpag06(object sender, EventArgs args)
        {
            App.Current.MainPage = new iMarket.Tela_06();
        }
    }
}