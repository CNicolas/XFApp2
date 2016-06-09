using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using XFApp2.Services;

namespace XFApp2.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private RelayCommand _sendNotifCommand;
        private INotificationService _notificationService;

        #region Public Properties
        public string MainText
        {
            get { return "Hello, it works !"; }
        }
        #region Commands

        public RelayCommand SendNotifCommand
        {
            get { return _sendNotifCommand ?? (_sendNotifCommand = new RelayCommand(SendNotif)); }
        }

        #endregion

        #endregion

        #region Constructors
        public HomeViewModel(INotificationService service)
        {
            if (service == null) throw new ArgumentNullException("service");
            _notificationService = service;
        }
        #endregion

        #region Private Methods

        private void SendNotif()
        {
            _notificationService.SendNotif();
        }

        #endregion
    }
}
