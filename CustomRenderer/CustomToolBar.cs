using System;
using System.Runtime;
using Xamarin.Forms;

namespace Shop.CustomRenderer
{
    public class CustomToolBar : ToolbarItem
    {
        public static readonly BindableProperty IconProperty = BindableProperty.Create(
            propertyName: "IconImageSource",
            returnType: typeof(string),
            declaringType: typeof(CustomToolBar),
            defaultValue: default(string));
            
        public string IconSource
        {
            get 
            {
                return (string)GetValue(IconProperty);
            }
            set 
            {
                SetValue(IconProperty, value);
            }
        }
    }
}