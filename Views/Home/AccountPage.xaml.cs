using System;
using System.IO;
using Xamarin.Forms;

namespace Shop.Views
{
	public partial class AccountPage : ContentPage
	{
		public AccountPage()
		{
			InitializeComponent();
			history.Position = 1;
			save.IsVisible = false;
			edit.IsVisible = true;
			//edit.IconImageSource = "assets/img/edit.png";
		}
		
		
		private async void OnClickedEdit(object sender, EventArgs e)
		{
		    save.IsVisible = true;
		    edit.IsVisible = false;
		    age.IsVisible = false;
		    age1.IsVisible = true;
		    age2.IsVisible = false;
		    address.IsVisible = false;
		    address1.IsVisible = true;
		    address2.IsVisible = false;
		    phoneNumber.IsVisible = false;
		    phoneNumber1.IsVisible = true;
		    phoneNumber2.IsVisible = false;
		}
		
		private async void OnClickedSave(object sender, EventArgs e)
		{
		    save.IsVisible = false;
		    edit.IsVisible = true;
		    age.IsVisible = true;
		    age1.IsVisible = false;
		    age2.IsVisible = true;
		    address.IsVisible = true;
		    address1.IsVisible = false;
		    address2.IsVisible = true;
		    phoneNumber.IsVisible = true;
		    phoneNumber1.IsVisible = false;
		    phoneNumber2.IsVisible = true;
		}
	}
}