using System;
using System.Windows.Input;

namespace HMI_for_Wafer_Handling_System
{

public class TransferCommand: ICommand
{
        private Action<object> execute;
        private Predicate<object> canExecute;
	public TransferCommand(Action<object> execute, Predicate<object> canExecute = null)
	{
        this.execute = execute;
        this.canExecute = canExecute;
	}

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => canExecute == null || canExecute(parameter);

        public void Execute(object? parameter) => execute(parameter);
    }
}
