using System;
namespace HMI_for_Wafer_Handling_System
{
public class RobotViewModel: BaseViewModel
{
        public string position;
        public bool carries_Wafer;

        public RobotViewModel(string position, bool carries_Wafer) {
            this.position = position;
            this.carries_Wafer = carries_Wafer;
        }
}
}