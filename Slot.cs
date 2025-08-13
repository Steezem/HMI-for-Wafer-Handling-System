using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace HMI_for_Wafer_Handling_System.Models
{
	public class Slot : INotifyPropertyChanged
	{
		private bool _is_filled;

		public event PropertyChangedEventHandler? PropertyChanged;

		public bool Is_filled {
			get => _is_filled;
			set {
				if (_is_filled != value) {
					_is_filled = value;
					OnPropertyChanged(nameof(Is_filled));
				}
			}
		}
		public int number { get; set; }
		public Wafer Wafer { get; set; }

		protected void OnPropertyChanged(string propertyName) {
			PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}