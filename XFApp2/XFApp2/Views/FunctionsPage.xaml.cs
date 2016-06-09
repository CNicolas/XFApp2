using Xamarin.Forms;

namespace XFApp2.Views
{
    public partial class FunctionsPage : ContentPage
    {
        public FunctionsPage()
        {
            InitializeComponent();
            BindingContext = App.Locator.Functions;
        }
    }
}
