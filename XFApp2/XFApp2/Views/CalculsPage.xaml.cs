using Xamarin.Forms;

namespace XFApp2.Views
{
    public partial class CalculsPage : ContentPage
    {
        public CalculsPage()
        {
            InitializeComponent();
            BindingContext = App.Locator.Calculs;
        }
    }
}
