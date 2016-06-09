using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using XFApp2.Services;
using XFApp2.Services.Implementations;

namespace XFApp2.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            // ViewModels
            SimpleIoc.Default.Register<MasterPageViewModel>();
            SimpleIoc.Default.Register<HomeViewModel>();
            SimpleIoc.Default.Register<CalculsViewModel>();
            SimpleIoc.Default.Register<FunctionsViewModel>();
            SimpleIoc.Default.Register<SaveAndLoadViewModel>();
            SimpleIoc.Default.Register<WebViewViewModel>();
            
            // Services
            SimpleIoc.Default.Register<ICalculsService, CalculsService>();
        }

        public MasterPageViewModel MasterPage
        {
            get { return ServiceLocator.Current.GetInstance<MasterPageViewModel>(); }
        }

        public HomeViewModel Home
        {
            get { return ServiceLocator.Current.GetInstance<HomeViewModel>(); }
        }

        public CalculsViewModel Calculs
        {
            get { return ServiceLocator.Current.GetInstance<CalculsViewModel>(); }
        }

        public FunctionsViewModel Functions
        {
            get { return ServiceLocator.Current.GetInstance<FunctionsViewModel>(); }
        }

        public SaveAndLoadViewModel SaveAndLoad
        {
            get { return ServiceLocator.Current.GetInstance<SaveAndLoadViewModel>(); }
        }

        public WebViewViewModel WebView
        {
            get { return ServiceLocator.Current.GetInstance<WebViewViewModel>(); }
        }
        
    }
}
