using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HMI_for_Wafer_Handling_System
{

    public class BaseViewModel : INotifyPropertyChanged
	{
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}