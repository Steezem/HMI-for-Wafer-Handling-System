using System;

namespace HMI_for_Wafer_Handling_System.Models
{
	public class LoadPort
	{
		public string Name { get; set; }
		public List<Slot> Slots { get; set; } = [];

		public LoadPort() {
		}
	}
}