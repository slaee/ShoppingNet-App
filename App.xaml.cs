using Shop.Auth;
using Shop.Views;
using Shop.Category;
using Shop.Product;
using Xamarin.Forms;

namespace Shop
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			MainPage = new NavigationPage(new HomeMasterPage());
		}
	}
}