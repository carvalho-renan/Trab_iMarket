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
        public void Voltarpag06(object sender, EventArgs args)
        {
            App.Current.MainPage = new iMarket.Tela_06();
        }
    }
}