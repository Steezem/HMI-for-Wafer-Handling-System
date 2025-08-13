using System;
using System.Windows.Input;

namespace HMI_for_Wafer_Handling_System
{

public class TransferCommand: ICommand
{
        private Action execute;
        private Func<bool> canExecute;
	public TransferCommand(Action execute, Func<bool> canExecute = null)
	{
        this.execute = execute;
        this.canExecute = canExecute;
	}

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) {
            return canExecute == null || canExecute();
        }

        public void Execute(object? parameter){
            execute();
        }

    }
}
