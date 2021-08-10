using System;
using Xamarin.Forms;
namespace Shop.Auth
{
	public partial class LoginPage
	{
		internal ContentView overlay;
		internal ProgressBar progressBar;
		void InitializeComponent()
		{
			Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(LoginPage));
				overlay = (ContentView)this.FindByName("overlay");
				progressBar = (ProgressBar)this.FindByName("progressBar");
		}
	}
}
