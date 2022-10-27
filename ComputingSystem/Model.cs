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
            deviceQueue = new FIFOQueue<Process, SimpleArray<Process>>(new SimpleArray<Process>());
            readyQueue = new PriorityQueue<Process, BinaryHeap<Process>>(new BinaryHeap<Process>());
            modelSettings = new Settings();
            idGen = new IdGenerator();
            processRand = new Random();
            cpu = new Resource();
            device = new Resource();
            cpuScheduler = new CPUScheduler(cpu, readyQueue);
            deviceScheduler = new DeviceScheduler(device, deviceQueue);
            memoryManager = new MemoryManager();
            ram = new Memory();
        }

        public void SaveSettings()
        {
            ram.Save(modelSettings.ValueOfRAMSize);
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
                        cpuScheduler.Session();
                    }
                }
            }
            cpu.WorkingCycle();
            device.WorkingCycle();
        }

        public void Clear()
        {
            cpu.Clear();
            device.Clear();
            ram.Clear();
            readyQueue = readyQueue.Clear();
            deviceQueue = deviceQueue.Clear();
            Clock.Clear();
            idGen.Clear();
        }

        private void FreeingResourceEventHandler (object sender, EventArgs e)
        {
            Process proc = sender as Process;
            if (proc.Status == ProcessStatus.waiting) //Процесс покидает внешнее устройство
            {
                device.Clear();
                proc.Status = ProcessStatus.ready;
                proc.BurstTime = processRand.Next(modelSettings.MinValueOfBurstTime, modelSettings.MaxValueOfBurstTime + 1);
                proc.ResetWorkTime();
                
                readyQueue = readyQueue.Put(proc);

                if(cpu.IsFree())
                {
                   readyQueue = cpuScheduler.Session();
                   Subscribe(Cpu.ActiveProcess);
                }

                if (deviceQueue.Count != 0) 
                {
                   deviceQueue = deviceScheduler.Session();
                   Subscribe(Device.ActiveProcess);
                }
            }
            else //Процесс покидает процессор
            {
                cpu.Clear();           
                if(readyQueue.Count != 0)
                {
                   readyQueue = cpuScheduler.Session();
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
                    deviceQueue = deviceQueue.Put(proc);
                    if(device.IsFree())
                    {
                        deviceQueue = deviceScheduler.Session();
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
        private Resource device;
        private IdGenerator idGen;
        private IQueueable<Process> deviceQueue;
        private IQueueable<Process> readyQueue;
        private CPUScheduler cpuScheduler;
        private DeviceScheduler deviceScheduler;
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

        public IQueueable<Process> DeviceQueue
        {
            get { return deviceQueue; }
            set 
            { 
                deviceQueue = value;
                OnPropertyChanged();
            }
        }

        public Settings ModelSettings
        {
            get { return modelSettings; }
        }

        public Resource Device
        {
            get { return device; }
        }

        public Resource Cpu
        {
            get { return cpu; }
        }
    }
}
