using System;
using Xamarin.Forms;
namespace Shop.Views
{
	public partial class Search
	{
		internal SearchBar searchBar;
		internal ImageButton BackArrow;
		internal ListView searchResults;
		void InitializeComponent()
		{
			Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(Search));
				searchBar = (SearchBar)this.FindByName("searchBar");
				BackArrow = (ImageButton)this.FindByName("BackArrow");
				searchResults = (ListView)this.FindByName("searchResults");
		}
	}
}
