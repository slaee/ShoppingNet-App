using System;
using Xamarin.Forms;
namespace Shop.Views
{
	public partial class PaSugoAKoPage
	{
		internal SearchBar searchBar;
		internal ListView searchResults;
		void InitializeComponent()
		{
			Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(PaSugoAKoPage));
				searchBar = (SearchBar)this.FindByName("searchBar");
				searchResults = (ListView)this.FindByName("searchResults");
		}
	}
}
