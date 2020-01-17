using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace square_rounding
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private double _value1;
        private double _value2;
        private double _result;

        public double Value1
        {
            get => _value1;
            set => OnPropertyChanged(ref _value1, value);
        }

        public double Value2
        {
            get => _value2;
            set => OnPropertyChanged(ref _value2, value);
        }

        public double Result
        {
            get => _result;
            set => OnPropertyChanged(ref _result, value);
        }

        public ICommand AddCommand { get; }

        public ICommand DivideCommand { get; }

        public MainWindowViewModel()
        {
            AddCommand = new RelayCommand(() => Result = Value1 + Value2);
            DivideCommand = new RelayCommand(() => Result = Value1 / Value2);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged<T>(ref T field, T value, [CallerMemberName]string propertyName = "")
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
