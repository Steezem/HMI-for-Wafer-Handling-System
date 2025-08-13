using HMI_for_Wafer_Handling_System.Models;
using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Windows.Threading;

namespace HMI_for_Wafer_Handling_System
{

	public class MainViewModel : INotifyPropertyChanged
    {
		public LoadPortViewModel LP1 { get; set; }
		public LoadPortViewModel LP2 { get; set; }
		public RobotViewModel Robot { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public ICommand StartCommand { get; }
		public ICommand PauseCommand { get; }

		public MainViewModel() {
			LP1 = new LoadPortViewModel(name: "LP1", filled: true);
			LP2 = new LoadPortViewModel(name: "LP2", filled: false);
			Robot = new RobotViewModel();

            StartCommand = new TransferCommand(async () => await StartTransferAsync(), () => !Robot.IsMoving);
            PauseCommand = new TransferCommand(() => Robot.IsMoving = false, () => Robot.IsMoving);
        }

        private async Task StartTransferAsync() {
            var slotFrom = LP1.Slots.LastOrDefault(s => s.Is_filled);
            var slotTo = LP2.Slots.LastOrDefault(s => !s.Is_filled);
            if (slotFrom == null || slotTo == null) return;

            await Robot.MoveRobotAsync(-180, 0);   
            slotFrom.Is_filled = false;
            slotTo.Is_filled = true;
            //await Robot.MoveRobotAsync(180, 0, false);
        }

	}
}
