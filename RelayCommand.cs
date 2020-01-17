using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace square_rounding
{
    public class RelayCommand : ICommand
    {
        private readonly Action _action;

        public RelayCommand(Action action) => _action = action ?? throw new ArgumentNullException(nameof(action));

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter) => _action();
    }
}
