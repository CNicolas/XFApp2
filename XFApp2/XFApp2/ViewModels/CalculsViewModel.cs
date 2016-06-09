using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using XFApp2.Services;

namespace XFApp2.ViewModels
{
    public class CalculsViewModel : ViewModelBase
    {
        #region Private properties
        private readonly ICalculsService _calculService;

        private readonly string _title = "Calculs";
        private readonly string _addButtonText = "ADD";
        private readonly string _divButtonText = "DIV";
        private readonly string _multButtonText = "MULT";
        private readonly string _subButtonText = "SUB";
        private readonly string _swapButtonText = "SWAP";

        private double _firstNumber;
        private double _secondNumber;
        private double _result;

        private RelayCommand _addCommand;
        private RelayCommand _divCommand;
        private RelayCommand _multCommand;
        private RelayCommand _subCommand;
        private RelayCommand _swapCommand;
        #endregion

        #region Public properties
        public string Title { get { return _title; } }
        public string AddButtonText { get { return _addButtonText; } }
        public string DivButtonText { get { return _divButtonText; } }
        public string MultButtonText { get { return _multButtonText; } }
        public string SubButtonText { get { return _subButtonText; } }
        public string SwapButtonText { get { return _swapButtonText; } }

        public double FirstNumber
        {
            get { return _firstNumber; }
            set
            {
                Set(GetPropertyName(() => FirstNumber), ref _firstNumber, value);
            }
        }
        public double SecondNumber
        {
            get { return _secondNumber; }
            set
            {
                Set(GetPropertyName(() => SecondNumber), ref _secondNumber, value);
            }
        }
        public double Result
        {
            get { return _result; }
            set
            {
                Set(GetPropertyName(() => Result), ref _result, value);
            }
        }

        #region Commands
        public RelayCommand AddCommand
        {
            get { return _addCommand ?? (_addCommand = new RelayCommand(Add)); }
        }
        public RelayCommand DivCommand
        {
            get { return _divCommand ?? (_divCommand = new RelayCommand(Div)); }
        }
        public RelayCommand MultCommand
        {
            get { return _multCommand ?? (_multCommand = new RelayCommand(Mult)); }
        }
        public RelayCommand SubCommand
        {
            get { return _subCommand ?? (_subCommand = new RelayCommand(Sub)); }
        }
        public RelayCommand SwapCommand
        {
            get { return _swapCommand ?? (_swapCommand = new RelayCommand(Swap)); }
        }
        #endregion

        #endregion

        #region Constructors
        public CalculsViewModel(ICalculsService service)
        {
            if (service == null) throw new ArgumentNullException("service");
            _calculService = service;
        }
        #endregion

        #region Private methods
        private void Add()
        {
            Result = _calculService.Addition(FirstNumber, SecondNumber);
        }
        private void Div()
        {
            try
            {
                Result = _calculService.Division(FirstNumber, SecondNumber);
            }
            catch (ArgumentException)
            {
                App.Current.MainPage.DisplayAlert("Error", "Division by 0 is impossible !", "OK");
            }
        }
        private void Mult()
        {
            Result = _calculService.Multiplication(FirstNumber, SecondNumber);
        }
        private void Sub()
        {
            Result = _calculService.Substraction(FirstNumber, SecondNumber);
        }

        private void Swap()
        {
            double tmp = FirstNumber;
            FirstNumber = SecondNumber;
            SecondNumber = tmp;
        }
        #endregion
    }
}
