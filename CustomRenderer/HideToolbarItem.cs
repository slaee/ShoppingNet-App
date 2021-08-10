using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Shop.CustomRenderer
{
    public class HideToolbarItem : ToolbarItem
    {
        public HideToolbarItem() : base()
        {
            this.InitVisibility();
        }

        private async void InitVisibility()
        {
            await Task.Delay(100);
            OnIsVisibleChanged(this, false, IsVisible);
        }

        public ContentPage Parent { set; get; }

        public bool IsVisible
        {
            get { return (bool)GetValue(IsVisibleProperty); }
            set { SetValue(IsVisibleProperty, value); }
        }

        public static BindableProperty IsVisibleProperty =
            BindableProperty.Create<HideToolbarItem, bool>(o => o.IsVisible, false, propertyChanged: OnIsVisibleChanged);
            
        public static readonly BindableProperty IconProperty = BindableProperty.Create(
            propertyName: "IconImageSource",
            returnType: typeof(string),
            declaringType: typeof(HideToolbarItem),
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

        private static void OnIsVisibleChanged(BindableObject bindable, bool oldvalue, bool newvalue)
        {
            var item = bindable as HideToolbarItem;

            if (item.Parent == null)
                return;

            var items = item.Parent.ToolbarItems;

            if (newvalue && !items.Contains(item))
            {
                items.Add(item);
            }
            else if (!newvalue && items.Contains(item))
            {
                items.Remove(item);
            }
        }
    }
}