using GalaSoft.MvvmLight;
using Xamarin.Forms;

namespace XFApp2.ViewModels
{
    public class WebViewViewModel : ViewModelBase
    {
        private WebViewSource _url;

        public string Url
        {
            get { return "https://www.google.fr/"; }
        }
    }
}
