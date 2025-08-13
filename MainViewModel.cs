using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Windows.Threading;
using HMI_for_Wafer_Handling_System.Models;

namespace HMI_for_Wafer_Handling_System
{

	public class MainViewModel : BaseViewModel
	{
		public LoadPortViewModel LP1 { get; set; }
		public LoadPortViewModel LP2 { get; set; }
		public RobotViewModel Robot { get; set; }

		private DispatcherTimer timer;

		public ICommand StartCommand { get; }
		public ICommand PauseCommand { get; }

		public MainViewModel() {
			LP1 = new LoadPortViewModel(name: "LP1", filled: true);
			LP2 = new LoadPortViewModel(name: "LP2", filled: false);
			Robot = new RobotViewModel(position: "LP1", carries_Wafer: false);

			StartCommand = new TransferCommand(_ => timer.Start());
			PauseCommand = new TransferCommand(_ => timer.Stop());

			timer = new DispatcherTimer();
			timer.Interval = TimeSpan.FromSeconds(1);
			timer.Tick += Timer_Tick;
		}

		private void Timer_Tick(object sender, EventArgs e) {

			if (!Robot.carries_Wafer) {

				var waferSlot = LP1.Slots.FirstOrDefault(s => s.Is_filled);
				if (waferSlot != null) {
					Robot.carries_Wafer = true;
					Robot.position = "LP2";
				}
			} else {
				var emptySlot = LP2.Slots.FirstOrDefault(s => !s.Is_filled);
				if (emptySlot != null) {
					Robot.carries_Wafer = false;
					Robot.position = "LP1";
				}
			}
			OnPropertyChanged(nameof(Robot));
			OnPropertyChanged(nameof(LP1));
			OnPropertyChanged(nameof(LP2));
		}
	}
}
