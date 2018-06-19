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
	public partial class Tela_07 : ContentPage
	{
		public Tela_07 ()
		{
			InitializeComponent ();
		}
        protected override bool OnBackButtonPressed()
        {
            App.Current.MainPage = new iMarket.Tela_06();
            return true;
        }
    }
}