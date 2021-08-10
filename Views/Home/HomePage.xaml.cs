using System;
using Shop.Category;
using Shop.CustomRenderer;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Shop.Model;
using System.Threading.Tasks;
using Shop.Product;
using Shop.ViewModel;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Shop.Views
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();
			MessagingCenter.Subscribe<PlaceHolder>(this, "StartProgress", (sender) =>
			{
                StartProgress();
            });
            
			Device.StartTimer(TimeSpan.FromSeconds(3), (Func<bool>)(() => {
                Automatic.Position = (Automatic.Position + 1) % 6;
                return true;
            }));
            
            categories.Position = 1;
            hotsale.Position = 1;
            
            var toolbar = new CustomToolBar 
            {
                Priority = 2
            };
        
            toolbar.SetBinding(ToolbarItem.IconImageSourceProperty, new Binding("icon"));
            
            toolbar.BindingContext = new {
                icon = "assets/img/shopcart.png"
            };
		}
		
		public async Task StartProgress()
		{
		    overlay.IsVisible = true;
		 TimeSpan duration = TimeSpan.FromSeconds(15);
		  DateTime startTime = DateTime.Now;
		  Device.StartTimer(TimeSpan.FromSeconds(0), () =>
		  {
		      double progress = (DateTime.Now - startTime).TotalMilliseconds /duration.TotalMilliseconds;
		      
		      progressBar.Progress = progress;
		      
		      bool continueTimer = progress < 1;
		 	    if (!continueTimer)
		 	    {
		 		    overlay.IsVisible = false;
		 	    }
		 	    return continueTimer;
		    });
		}
		
		private async void OnClickedCategory(object sender, EventArgs e)
		{
		    await Navigation.PushAsync(new SelectedCategory());
		}
		
		private async void OnClickedHotProduct(object sender, EventArgs e)
		{
		    await Navigation.PushAsync(new SelectedProduct());
		}
		
		private void OnClickedBuyNow(object sender, EventArgs e)
		{
		    
		}
		
		private async void OnClickedCart(object sender, EventArgs e)
		{
		    await Navigation.PushAsync(new Cart());
		}
		
		private async void OnClickedSearch(object sender, EventArgs e)
		{
		    await Navigation.PushAsync(new Search());
		}
	}
}