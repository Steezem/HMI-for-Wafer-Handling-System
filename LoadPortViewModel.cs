using HMI_for_Wafer_Handling_System.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace HMI_for_Wafer_Handling_System
{
public class LoadPortViewModel : INotifyPropertyChanged
    {
		public string Name { get; set; }
		public ObservableCollection<Slot> Slots { get; set; } = new ObservableCollection<Slot>();

	public LoadPortViewModel(string name, bool filled)
	{
			Name = name;
			for (int i = 0; i < 25; i++) {
				Slots.Add(new Slot(number: i, is_filled: filled));
				};
			}

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}