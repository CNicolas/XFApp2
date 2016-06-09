using Xamarin.Forms;

namespace XFApp2.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = App.Locator.Home;
        }
    }
}
