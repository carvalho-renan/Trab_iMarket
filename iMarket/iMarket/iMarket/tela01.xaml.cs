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
	public partial class tela01 : ContentPage
	{
		public tela01 ()
		{
			InitializeComponent ();
		}
        public void voltarpaginicial(object sender, EventArgs args)
        {
            App.Current.MainPage = new iMarket.MainPage();
        }
	}
}