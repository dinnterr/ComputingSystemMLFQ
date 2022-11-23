using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ComputingSystem
{
    class Memory : INotifyPropertyChanged
    {
        public void Save(long size)
        {
            Size = size;
            OccupiedSize = 0;
           // FreeSize = size;
        }
        public void Clear()
        {
            OccupiedSize = 0;
            Size = 0;
        }
        public long Size
        {
            get;
            private set;
        }
        public long OccupiedSize
        {
            get { return occupiedSize; }
            set { occupiedSize = value; FreeSize = Size - occupiedSize; OnPropertyChanged(); }
        }
        public long FreeSize
        {
            get {return Size - occupiedSize; }
            private set { }
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

        private long occupiedSize;
    }
}
