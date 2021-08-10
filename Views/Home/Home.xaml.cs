using System;
using Xamarin.Forms;

namespace Shop.Views
{
	public partial class Home : TabbedPage
	{
		public Home()
		{
			InitializeComponent();
			CurrentPage = Children[1];
		}
	}
}