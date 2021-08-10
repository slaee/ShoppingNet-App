using System;
using System.Text;
using Shop.Model;
using Xamarin.Forms;

namespace Shop.Views
{
	public partial class PaSugoAKoPage : ContentPage
	{
		public PaSugoAKoPage()
		{
			InitializeComponent();
			
			searchResults.ItemsSource = DataService.GetSearchResults(searchBar.Text);
		}
		
		void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            searchResults.ItemsSource = DataService.GetSearchResults(e.NewTextValue);
        }
	}
}