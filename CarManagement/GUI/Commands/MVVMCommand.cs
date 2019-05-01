using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GUI.Commands
{
    public class MVVMCommand : ICommand
    {

        Action<object> executeAction;
        Func<object, bool> canExecute;

        public MVVMCommand(Action<object> executeAction, Func<object, bool> canExecute)
        {
            this.canExecute = canExecute;
            this.executeAction = executeAction;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute == null ? true : canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            executeAction(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }


    }
}
