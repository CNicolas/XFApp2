using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XFApp2.Views
{
    public partial class SecondContentPage : ContentPage
    {
        public SecondContentPage()
        {
            InitializeComponent();
            BindingContext = App.Locator.SecondContent;
        }
    }
}
