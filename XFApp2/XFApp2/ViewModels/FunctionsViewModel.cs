using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using XFApp2.Services;

namespace XFApp2.ViewModels
{
    public class FunctionsViewModel : ViewModelBase
    {
        #region Private properties
        private readonly ICalculsService _calculService;

        private readonly string _title = "Functions";
        private readonly string _factButtonText = "Factorial";
        private readonly string _fibButtonText = "Fibonacci";
        private readonly string _rootButtonText = "Square Root";
        private readonly string _squareButtonText = "Square";
        private readonly string _isPrimeButtonText = "Is Prime ?";

        private double _number;
        private string _result;

        private RelayCommand _factCommand;
        private RelayCommand _fibCommand;
        private RelayCommand _rootCommand;
        private RelayCommand _squareCommand;
        private RelayCommand _isPrimeCommand;
        #endregion

        #region Public properties

        #region Text
        public string Title { get { return _title; } }
        public string FactButtonText { get { return _factButtonText; } }
        public string FibButtonText { get { return _fibButtonText; } }
        public string RootButtonText { get { return _rootButtonText; } }
        public string SquareButtonText { get { return _squareButtonText; } }
        public string IsPrimeButtonText { get { return _isPrimeButtonText; } }
        #endregion

        public double Number
        {
            get { return _number; }
            set
            {
                Set(GetPropertyName(() => Number), ref _number, value);
            }
        }
        public string Result
        {
            get { return _result; }
            set
            {
                Set(GetPropertyName(() => Result), ref _result, value);
            }
        }

        #region Commands
        public RelayCommand FactCommand
        {
            get { return _factCommand ?? (_factCommand = new RelayCommand(Factorial)); }
        }
        public RelayCommand FibCommand
        {
            get { return _fibCommand ?? (_fibCommand = new RelayCommand(Fibonacci)); }
        }
        public RelayCommand RootCommand
        {
            get { return _rootCommand ?? (_rootCommand = new RelayCommand(SquareRoot)); }
        }
        public RelayCommand SquareCommand
        {
            get { return _squareCommand ?? (_squareCommand = new RelayCommand(Square)); }
        }
        public RelayCommand IsPrimeCommand
        {
            get { return _isPrimeCommand ?? (_isPrimeCommand = new RelayCommand(IsPrime)); }
        }
        #endregion

        #endregion

        #region Constructors
        public FunctionsViewModel(ICalculsService service)
        {
            if (service == null) throw new ArgumentNullException("service");
            _calculService = service;
        }
        #endregion

        #region Private methods
        private void Factorial()
        {
            Result = _calculService.Factorial((int)Number).ToString();
        }
        private void Fibonacci()
        {
            Result = _calculService.Fibonacci((int)Number).ToString();
        }
        private void SquareRoot()
        {
            Result = _calculService.SquareRoot(Number).ToString();
        }
        private void Square()
        {
            Result = _calculService.Square(Number).ToString();
        }
        private void IsPrime()
        {
            Result = _calculService.IsPrime((int)Number).ToString();
        }
        #endregion
    }
}
