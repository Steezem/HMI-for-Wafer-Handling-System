using HMI_for_Wafer_Handling_System.Models;
using System;
using System.ComponentModel;

namespace HMI_for_Wafer_Handling_System
{
    public class RobotViewModel : INotifyPropertyChanged
    {

        private bool _isMoving;
        public bool IsMoving {
            get => _isMoving;
            set { _isMoving = value; OnPropertyChanged(nameof(IsMoving)); }
        }

        private bool _robotHasWafer;
        public bool RobotHasWafer {
            get => _robotHasWafer;
            set { _robotHasWafer = value; OnPropertyChanged(nameof(RobotHasWafer)); }
        }

        private double _rotationAngle;

        public double RotationAngle {
            get => _rotationAngle;
            set {
                if (_rotationAngle != value) {
                    _rotationAngle = value;
                    OnPropertyChanged(nameof(RotationAngle));
                }
            }
        }

        public async Task MoveRobotAsync(int from, int to) {
            IsMoving = true;
            RobotHasWafer = true;
            for (int i = from; i <= to; i += 5) {
                RotationAngle = i; 
                await Task.Delay(15); 
            }

            RobotHasWafer = false; 

            for (int i = to; i >= from; i -= 5) {
                RotationAngle = i; 
                await Task.Delay(15); 
            }
            IsMoving = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}