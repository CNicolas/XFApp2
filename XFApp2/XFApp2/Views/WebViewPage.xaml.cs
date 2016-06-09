using Xamarin.Forms;

namespace XFApp2.Views
{
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();
            BindingContext = App.Locator.WebView;
        }
    }
}
