using System;
using Xamarin.Forms;
namespace Shop.Views
{
	public partial class Welcome
	{
		internal IndicatorView indicatorView;
		void InitializeComponent()
		{
			Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(Welcome));
				indicatorView = (IndicatorView)this.FindByName("indicatorView");
		}
	}
}
