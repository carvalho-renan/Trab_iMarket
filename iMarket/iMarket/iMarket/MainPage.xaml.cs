using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace iMarket
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        public void mudarparapag01(object sender, EventArgs args)
        {
            App.Current.MainPage = new iMarket.tela01();
        }

	}
}
