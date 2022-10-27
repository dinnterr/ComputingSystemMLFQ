using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ComputingSystem
{
    class Resource : INotifyPropertyChanged
    {
        public void WorkingCycle()
        {
            if (!IsFree())
            {
                activeProcess.IncreaseWorkTime();
            }
        }

        public bool IsFree()
        {
            return activeProcess == null;
        }

        public void Clear()
        {
            activeProcess = null;
        }

        public Process ActiveProcess
        {
            get
            {
                return activeProcess;
            }
            set
            {
                activeProcess = value;
                OnPropertyChanged();
            }
        }

        //издатель
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private Process activeProcess;
    }
}
