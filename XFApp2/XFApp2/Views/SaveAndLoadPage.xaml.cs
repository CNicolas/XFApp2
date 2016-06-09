using Xamarin.Forms;

namespace XFApp2.Views
{
    public partial class SaveAndLoadPage : ContentPage
    {
        public SaveAndLoadPage()
        {
            InitializeComponent();
            BindingContext = App.Locator.SaveAndLoad;
        }
    }
}
