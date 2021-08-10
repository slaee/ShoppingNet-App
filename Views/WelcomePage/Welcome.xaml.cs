using System;
using Xamarin.Forms;

namespace Shop.Views
{
	public partial class Welcome : ContentPage
	{
		public Welcome()
		{
			InitializeComponent();
		}
		
		private void skip(object sender, EventArgs e)
		{
		    Application.Current.MainPage = new NavigationPage(new Home());
		}
		
		private void getStarted(object sender, EventArgs e)
		{
		    Application.Current.MainPage = new NavigationPage(new Home());
		}
	}
}