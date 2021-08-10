using System;
using Xamarin.Forms;
namespace Shop.Views
{
	public partial class HomeMasterPage
	{
		internal ContentPage masterPage;
		void InitializeComponent()
		{
			Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(HomeMasterPage));
				masterPage = (ContentPage)this.FindByName("masterPage");
		}
	}
}
