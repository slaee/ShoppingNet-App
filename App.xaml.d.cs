using System;
using Xamarin.Forms;
namespace Shop
{
	public partial class App
	{
		void InitializeComponent()
		{
			Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(App));
		}
	}
}
