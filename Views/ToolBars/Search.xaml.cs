using System;
using Shop.Model;
using Shop.Product;
using Xamarin.Forms;

namespace Shop.Views
{
	public partial class Search : ContentPage
	{
		public Search()
		{
			InitializeComponent();
			
			searchResults.ItemsSource = DataService.GetSearchResults(searchBar.Text);
		}
		
		private async void OnTapped(object sender, ItemTappedEventArgs e)
		{
		    await Navigation.PushModalAsync(new SelectedProduct());
		}
		
		private async void OnClicked(object sender, EventArgs e)
		{
		    await Navigation.PopToRootAsync(true);
		}
		
		protected override async void OnAppearing()
		{
		    base.OnAppearing();
		    await searchBar.TranslateTo(0,0, 100);
		    await BackArrow.TranslateTo(0, 0,100);
		}
		
		protected override async void OnDisappearing()
		{
		    base.OnDisappearing();
		    await searchBar.TranslateTo(0,-100, 100);
		    await BackArrow.TranslateTo(-100, 0,50);
		}
		
		void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            searchResults.ItemsSource = DataService.GetSearchResults(e.NewTextValue);
        }
	}
}