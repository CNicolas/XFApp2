
using Android.App;
using Android.Content.PM;
using Android.OS;
using GalaSoft.MvvmLight.Ioc;
using XFApp2.Droid.Services;
using XFApp2.Services;

namespace XFApp2.Droid
{
    [Activity(Label = "XFApp2", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SimpleIoc.Default.Register<INotificationService, NotificationService>();
            SimpleIoc.Default.Register<ISaveAndLoadService, SaveAndLoadService>();

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }


    }
}

