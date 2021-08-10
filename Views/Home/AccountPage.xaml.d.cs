using System;
using Xamarin.Forms;
using Shop.CustomRenderer;
namespace Shop.Views
{
	public partial class AccountPage
	{
		internal ContentPage This;
		internal HideToolbarItem edit;
		internal HideToolbarItem save;
		internal CarouselView history;
		internal Label age;
		internal Entry age1;
		internal Frame age2;
		internal Label address;
		internal Entry address1;
		internal Frame address2;
		internal Label phoneNumber;
		internal Entry phoneNumber1;
		internal Frame phoneNumber2;
		void InitializeComponent()
		{
			Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(AccountPage));
				This = (ContentPage)this.FindByName("This");
				edit = (HideToolbarItem)this.FindByName("edit");
				save = (HideToolbarItem)this.FindByName("save");
				history = (CarouselView)this.FindByName("history");
				age = (Label)this.FindByName("age");
				age1 = (Entry)this.FindByName("age1");
				age2 = (Frame)this.FindByName("age2");
				address = (Label)this.FindByName("address");
				address1 = (Entry)this.FindByName("address1");
				address2 = (Frame)this.FindByName("address2");
				phoneNumber = (Label)this.FindByName("phoneNumber");
				phoneNumber1 = (Entry)this.FindByName("phoneNumber1");
				phoneNumber2 = (Frame)this.FindByName("phoneNumber2");
		}
	}
}
