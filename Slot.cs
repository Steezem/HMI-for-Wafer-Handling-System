using System;
using System.Security.Cryptography.X509Certificates;

namespace HMI_for_Wafer_Handling_System.Models
{
	public class Slot
	{
        public int number { get; set; }
		public Wafer Wafer { get; set; }

        public Slot() {

			}
	}
}