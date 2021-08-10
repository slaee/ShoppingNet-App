using System;
using Xamarin.Forms;
namespace Shop.Views
{
	public partial class SplashScreen
	{
		internal Label label;
		void InitializeComponent()
		{
			Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(SplashScreen));
				label = (Label)this.FindByName("label");
		}
	}
}
