using System;
using Xamarin.Forms;
namespace Shop.Views
{
	public partial class HomePage
	{
		internal ToolbarItem MenuItem;
		internal CarouselView Automatic;
		internal CarouselView categories;
		internal CarouselView hotsale;
		internal ContentView overlay;
		internal ProgressBar progressBar;
		void InitializeComponent()
		{
			Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(HomePage));
				MenuItem = (ToolbarItem)this.FindByName("MenuItem");
				Automatic = (CarouselView)this.FindByName("Automatic");
				categories = (CarouselView)this.FindByName("categories");
				hotsale = (CarouselView)this.FindByName("hotsale");
				overlay = (ContentView)this.FindByName("overlay");
				progressBar = (ProgressBar)this.FindByName("progressBar");
		}
	}
}
