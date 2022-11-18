using System;
using System.Collections.Generic;
using System.Text;
using Queues;
using Structures;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ComputingSystem
{
      class Model : INotifyPropertyChanged
    {
        public Model()
        {
            Clock = new SystemClock();
            deviceQueue1 = new FIFOQueue<Process, SimpleArray<Process>>(new SimpleArray<Process>());
            deviceQueue2 = new FIFOQueue<Process, SimpleArray<Process>>(new SimpleArray<Process>());
            readyQueue = new PriorityQueue<Process, BinaryHeap<Process>>(new BinaryHeap<Process>());
            modelSettings = new Settings();
            idGen = new IdGenerator();
            processRand = new Random();
            cpu = new Resource();
            device1 = new Resource();
            device2 = new Resource();
            cpuScheduler = new CPUScheduler(cpu, readyQueue);
            deviceScheduler1 = new DeviceScheduler(device1, deviceQueue1);
            deviceScheduler2 = new DeviceScheduler(device2, deviceQueue2);
            memoryManager = new MemoryManager();
            ram = new Memory();
        }

        public void SaveSettings()
        {
            ram.Save(modelSettings.ValueOfRAM);
            memoryManager.Save(ram);
        }

        public void WorkingCycle()
        {
            Clock.WorkingCycle();
            if (processRand.NextDouble() <= modelSettings.Intensity)
            {
                Process proc = new Process(idGen.Id,
                    processRand.Next(modelSettings.MinValueOfAddrSpace, modelSettings.MaxValueOfAddrSpace + 1));
               if (memoryManager.Allocate(proc) != null)
               {
                    
                    proc.BurstTime = processRand.Next(modelSettings.MinValueOfBurstTime,
                        modelSettings.MaxValueOfBurstTime + 1);
                    Subscribe(proc);
                    readyQueue = readyQueue.Put(proc);
                    if (cpu.IsFree())
                    {
                        ReadyQueue = cpuScheduler.Session();
                    }
                }
            }
            cpu.WorkingCycle();
            device1.WorkingCycle();
            device2.WorkingCycle();
        }

        public void Clear()
        {
            cpu.Clear();
            device1.Clear();
            device2.Clear();
            ram.Clear();
            readyQueue = readyQueue.Clear();
            deviceQueue1 = deviceQueue1.Clear();
            deviceQueue2 = deviceQueue2.Clear();
            Clock.Clear();
            idGen.Clear();
        }

        private void FreeingResourceEventHandler (object sender, EventArgs e)
        {
            Process proc = sender as Process;
            if (proc.Status == ProcessStatus.waiting) //Процесс покидает внешнее устройство
            {
                device1.Clear();
                device2.Clear();
                proc.Status = ProcessStatus.ready;
                proc.BurstTime = processRand.Next(modelSettings.MinValueOfBurstTime, modelSettings.MaxValueOfBurstTime + 1);
                proc.ResetWorkTime();
                
                ReadyQueue = readyQueue.Put(proc);

                if(cpu.IsFree())
                {
                   ReadyQueue = cpuScheduler.Session();
                   Subscribe(Cpu.ActiveProcess);
                }

                if (deviceQueue1.Count != 0) 
                {
                   DeviceQueue1 = deviceScheduler1.Session();
                   Subscribe(Device1.ActiveProcess);
                }

                //if (deviceQueue2.Count != 0)
                //{
                //    DeviceQueue2 = deviceScheduler2.Session();
                //    Subscribe(Device2.ActiveProcess);
                //}
            }
            else //Процесс покидает процессор
            {
                cpu.Clear();           
                if(readyQueue.Count != 0)
                {
                   ReadyQueue = cpuScheduler.Session();
                }
             
                proc.Status = processRand.Next(0, 2) == 0 ? ProcessStatus.terminated : ProcessStatus.waiting;
                if(proc.Status == ProcessStatus.terminated)
                {
                    memoryManager.Free(proc);
                    Unsubscribe(proc);
                }
                else
                {
                    proc.BurstTime = processRand.Next(modelSettings.MinValueOfBurstTime, modelSettings.MaxValueOfBurstTime + 1);
                    proc.ResetWorkTime();
                    DeviceQueue1 = deviceQueue1.Put(proc);
                    DeviceQueue2 = deviceQueue2.Put(proc);
                    if (device1.IsFree())
                    {
                        DeviceQueue1 = deviceScheduler1.Session();
                    }
                    else
                    {
                        DeviceQueue2 = deviceScheduler2.Session();
                    }
                }
            }
        }
        private void Subscribe(Process proc)
        {
            if (proc != null)
            {
                proc.FreeingAResource += FreeingResourceEventHandler;
            }
        }

        private void Unsubscribe(Process proc)
        {
            if (proc != null)
            {
                proc.FreeingAResource -= FreeingResourceEventHandler;
            }
        }

        //Издатель события PropertyChangedHandler
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public readonly SystemClock Clock;
        private Resource cpu;
        private Resource device1;//
        private Resource device2;
        private IdGenerator idGen;
        private IQueueable<Process> deviceQueue1;//
        private IQueueable<Process> deviceQueue2;
        private IQueueable<Process> readyQueue;
        private CPUScheduler cpuScheduler;
        private DeviceScheduler deviceScheduler1;
        private DeviceScheduler deviceScheduler2;
        private MemoryManager memoryManager;
        private Settings modelSettings;
        private Random processRand;
        public readonly Memory ram;

        public IQueueable<Process> ReadyQueue
        {
            get { return readyQueue; }
            set 
            { 
                readyQueue = value;
                OnPropertyChanged();
            }
        }

        public IQueueable<Process> DeviceQueue1
        {
            get { return deviceQueue1; }
            set 
            { 
                deviceQueue1 = value;
                OnPropertyChanged();
            }
        }

        public IQueueable<Process> DeviceQueue2
        {
            get { return deviceQueue2; }
            set
            {
                deviceQueue2 = value;
                OnPropertyChanged();
            }
        }

        public Settings ModelSettings
        {
            get { return modelSettings; }
        }

        public Resource Device1
        {
            get { return device1; }
        }

        public Resource Device2
        {
            get { return device2; }
        }

        public Resource Cpu
        {
            get { return cpu; }
        }
    }
}
