using System;
using System.IO;
using Xamarin.Forms;

namespace Shop.Views
{
	public partial class SplashScreen : ContentPage
	{
		public SplashScreen()
		{
			InitializeComponent();
		}
		
		protected override async void OnAppearing()
		{
		    base.OnAppearing();
		    await label.FadeTo(0,5000);
		    Application.Current.MainPage = new NavigationPage(new Home());
		}
	}
}