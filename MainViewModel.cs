using System;
using System.Windows.Input;

namespace HMI_for_Wafer_Handling_System.ViewModels
{

public class MainViewModel : BaseViewModel
{
		public LoadPortViewModel LP1 { get; set; }
		public LoadPortViewModel LP2 { get; set; }
		public RobotViewModel Robot { get; set; }


		public ICommand StartCommand { get; }
		public ICommand PauseCommand { get; }

	public MainViewModel()
	{
			LP1 = new LoadPortViewModel(name: "LP1", filled: true);
			LP2 = new LoadPortViewModel(name: "LP2", filled: false);
			Robot = new RobotViewModel(position: "LP1", carries_Wafer: false);
	}
}
}