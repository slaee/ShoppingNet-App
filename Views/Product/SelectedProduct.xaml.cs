using System;
using System.IO;
using Xamarin.Forms;

namespace Shop.Product
{
	public partial class SelectedProduct : ContentPage
	{
		public SelectedProduct()
		{
			InitializeComponent();
		}
		
		private async void OnClickedBack(object sender, EventArgs e)
		{
		    await Navigation.PopModalAsync(true);
		}
	}
}