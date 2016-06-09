using Android.App;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using Xamarin.Forms;
using XFApp2.Services;

namespace XFApp2.ViewModels
{
    public class SaveAndLoadViewModel : ViewModelBase
    {
        #region Private properties

        //private ISaveAndLoadService _saveAndLoadService;

        private string _textToSave;
        private string _loadedText;

        private RelayCommand _saveTextCommand;
        private RelayCommand _loadTextCommand;

        #endregion


        #region Public properties

        public string TextToSave
        {
            get { return _textToSave; }
            set { Set(GetPropertyName(() => TextToSave), ref _textToSave, value); }
        }

        public string LoadedText
        {
            get { return _loadedText; }
            set { Set(GetPropertyName(() => LoadedText), ref _loadedText, value); }
        }

        #region Commands

        public RelayCommand SaveTextCommand
        {
            get { return _saveTextCommand ?? (_saveTextCommand = new RelayCommand(SaveText)); }
        }

        public RelayCommand LoadTextCommand
        {
            get { return _loadTextCommand ?? (_loadTextCommand = new RelayCommand(LoadText)); }
        }

        #endregion

        #endregion


        #region Constructor

        //public SaveAndLoadViewModel(ISaveAndLoadService service)
        //{
        //    if (service == null) throw new ArgumentNullException("service");
        //    _saveAndLoadService = service;
        //}

        #endregion


        #region Private Methods

        private void SaveText()
        {
            DependencyService.Get<ISaveAndLoadService>().SaveText("file.txt", TextToSave);
        }

        private void LoadText()
        {
            LoadedText = DependencyService.Get<ISaveAndLoadService>().LoadText("file.txt");
        }

        #endregion
    }
}
