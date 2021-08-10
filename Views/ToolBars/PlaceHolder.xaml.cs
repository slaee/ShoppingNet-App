using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Shop.Views
{
	public partial class PlaceHolder : ContentPage
	{
		public PlaceHolder()
		{
			InitializeComponent();
		}
		
		public async void OnPlaceOrder(object s, EventArgs e)
		{
		    MessagingCenter.Send(this, "StartProgress");
		    await Navigation.PopToRootAsync(true);
		}
	}
}