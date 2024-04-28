using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertetBindingTest
{
    // ViewModel.cs
    public class ViewModel : INotifyPropertyChanged
    {
        private string _inputA = string.Empty;
        public string InputA
        {
            get => _inputA;
            set
            {
                _inputA = value;
                OnPropertyChanged(nameof(InputA));
            }
        }

        private string _inputB = string.Empty;
        public string InputB
        {
            get => _inputB;
            set
            {
                _inputB = value;
                OnPropertyChanged(nameof(InputB));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
