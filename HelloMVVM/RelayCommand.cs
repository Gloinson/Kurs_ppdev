using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HelloMVVM
{
    public class RelayCommand : ICommand
    {
        private readonly Action _execAction;
        private Func<bool> _canExecute;

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public RelayCommand(Action exec, Func<bool> canExec) : this(exec) =>
            _canExecute = canExec ?? throw new ArgumentNullException("Exec must not be null.");

        public RelayCommand(Action exec) =>
            _execAction = exec ?? throw new ArgumentNullException("Exec must not be null.");

        public bool CanExecute(object parameter) => _canExecute?.Invoke() ?? true;
        public void Execute(object parameter) => _execAction?.Invoke();
    }
}
