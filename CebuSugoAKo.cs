using XamarinFormsUiLib;

namespace Shop
{
    public class CebuSugoAKo 
    {
        public static void Main()
        {
            Ui.RunOnUiThread(() => {
                Ui.LoadApplication(new App());
                Ui.Orientation = ScreenOrientation.Portrait;
            });
        }
    }
}