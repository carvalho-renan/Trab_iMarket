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
	public partial class Tela_08 : ContentPage
	{
		public Tela_08 ()
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