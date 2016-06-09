using Foundation;
using UIKit;
using XFApp2.Services;

namespace XFApp2.iOS.Services
{
    class NotificationService : INotificationService
    {
        public void SendNotif()
        {
            UILocalNotification notification = new UILocalNotification();
            NSDate.FromTimeIntervalSinceNow(15);
            //notification.AlertTitle = "Alert Title"; // required for Apple Watch notifications
            notification.AlertAction = "View Alert";
            notification.AlertBody = "Your 15 second alert has fired!";
            UIApplication.SharedApplication.ScheduleLocalNotification(notification);
        }
    }
}