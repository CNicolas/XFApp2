using Android.App;
using Android.Content;
using Java.Util;
using Xamarin.Forms;
using XFApp2.Services;

namespace XFApp2.Droid.Services
{
    class NotificationService : INotificationService
    {
        public void SendNotif()
        {
            // Instantiate the builder and set notification elements:
            Notification.Builder builder = new Notification.Builder(Forms.Context);
            builder.SetContentTitle("TitreNotif");
            builder.SetContentText("Du contenu !");
            builder.SetSmallIcon(Resource.Drawable.ic_setting_light);

            // Build the notification:
            Notification notification = builder.Build();

            // Get the notification manager:
            NotificationManager notificationManager = Forms.Context.GetSystemService(Context.NotificationService) as NotificationManager;

            Random random = new Random();
            int notificationId = random.NextInt(1001);

            // Publish the notification:
            notificationManager.Notify(notificationId, notification);
        }
    }
}