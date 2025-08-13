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

        public async Task MoveRobotAsync(double from, double to, bool pickUp) {
            IsMoving = true;
            RobotHasWafer = true;
            for (int i = 180; i >= 0; i -= 5) {
                RotationAngle = i; 
                await Task.Delay(10); 
            }

            RobotHasWafer = false; 
            IsMoving = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}