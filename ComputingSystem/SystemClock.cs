using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ComputingSystem
{
    class SystemClock : INotifyPropertyChanged
    {
        public void WorkingCycle()
        {
            Clock++;
        }

        public void Clear()
        {
            Clock = 0;
        }

        public long Clock
        {
            get
            {
                return clock;
            }
            private set
            {
                clock = value;
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

        private long clock;
    }
}
