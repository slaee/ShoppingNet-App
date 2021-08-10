using System;
using Xamarin.Forms;
namespace Shop.Views
{
	public partial class PlaceHolder
	{
		void InitializeComponent()
		{
			Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(PlaceHolder));
		}
	}
}
