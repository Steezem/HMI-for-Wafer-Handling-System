using System;
namespace HMI_for_Wafer_Handling_System.ViewModels
{
public class RobotViewModel: BaseViewModel
{
        private string position;
        private bool carries_Wafer;

        public RobotViewModel(string position, bool carries_Wafer) {
            this.position = position;
            this.carries_Wafer = carries_Wafer;
        }
}
}