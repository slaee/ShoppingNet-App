using System;
using Xamarin.Forms;

namespace Shop.Views
{
	public partial class Cart : ContentPage
	{
		public Cart()
		{
			InitializeComponent();
		}
		
		public async void OnClickCheckout(object sender, EventArgs e)
		{
		    await Navigation.PushAsync(new PlaceHolder());
		}
	}
}