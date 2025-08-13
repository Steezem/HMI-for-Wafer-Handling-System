using System;

namespace HMI_for_Wafer_Handling_System.Models
{
	public class RobotArm
	{
		public String current_LP {  get; set; }
		public bool carries_Wafer { get; set; }

		public RobotArm() {
		}
	}
}