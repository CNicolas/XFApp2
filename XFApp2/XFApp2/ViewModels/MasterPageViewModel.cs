using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using XFApp2.Views;

namespace XFApp2.ViewModels
{
    public class MasterPageViewModel : ViewModelBase
    {
        private List<MasterPageItem> _masterPageItems;
        private MasterPageItem _selectedMasterItem;

        public List<MasterPageItem> MasterPageItems
        {
            get { return _masterPageItems; }
            set { Set(GetPropertyName(() => MasterPageItems), ref _masterPageItems, value); }
        }

        public MasterPageItem SelectedMasterItem
        {
            get { return _selectedMasterItem; }
            set
            {
                if (value != null)
                {
                    ((MasterDetailPage)Application.Current.MainPage).Detail = new NavigationPage((Page)Activator.CreateInstance(value.TargetType));
                    Set(GetPropertyName(() => SelectedMasterItem), ref _selectedMasterItem, null);
                    ((MasterDetailPage)Application.Current.MainPage).IsPresented = false;
                }
            }
        }

        public MasterPageViewModel()
        {
            MasterPageItems = new List<MasterPageItem>();

            MasterPageItems.Add(new MasterPageItem("Home", typeof(HomePage)));
            MasterPageItems.Add(new MasterPageItem("Calculs", typeof(CalculsPage)));
            MasterPageItems.Add(new MasterPageItem("Functions", typeof(FunctionsPage)));
            MasterPageItems.Add(new MasterPageItem("SaveAndLoad", typeof(SaveAndLoadPage)));
            MasterPageItems.Add(new MasterPageItem("WebView", typeof(WebViewPage)));

            SelectedMasterItem = null;
        }
    }
}
