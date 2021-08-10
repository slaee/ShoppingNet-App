using System;
using Shop.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Shop.Auth
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
		}
		
		private void OnClickedLogin(object sender, EventArgs e)
		{
		    overlay.IsVisible = true;
		    
		    TimeSpan duration = TimeSpan.FromSeconds(3);
            
            DateTime startTime = DateTime.Now;
            
            Device.StartTimer(TimeSpan.FromSeconds(0), () =>
            {
                double progress = (DateTime.Now - startTime).TotalMilliseconds /duration.TotalMilliseconds;
                    progressBar.Progress = progress;
                bool continueTimer = progress < 1;
                if (!continueTimer) 
                {
                    overlay.IsVisible = false;
                    Application.Current.MainPage = new NavigationPage(new Home());
                }
                return continueTimer;
            });
		}
		
		private async void OnClickedSignUp(object sender, EventArgs e)
		{
		    var uri = new Uri("https://amazon.com");  
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);  
		}
	}
}