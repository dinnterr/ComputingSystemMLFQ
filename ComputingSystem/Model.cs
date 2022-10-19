using System;
using System.Collections.Generic;
using System.Text;
using Queues;
using Structures;

namespace ComputingSystem
{
    class Model
    {
        public Model()
        {
            clock = new SystemClock();
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

        void SaveSettings()
        {
            ram.Save(modelSettings.ValueOfRAMSize);
            memoryManager.Save(ram.Size);
        }
        void WorkingCycle()
        {
            clock.WorkingCycle();
            if (processRand.NextDouble() <= modelSettings.Intensity)
            {
                Process proc = new Process(idGen.Id,
                    processRand.Next(modelSettings.MinValueOfAddrSpace, modelSettings.MaxValueOfAddrSpace + 1));
                if (memoryManager.Allocate(proc) != null)
                {
                    proc.BurstTime = processRand.Next(modelSettings.MinValueOfBurstTime,
                        modelSettings.MaxValueOfBurstTime + 1);
                    readyQueue.Put(proc);
                    if (cpu.IsFree())
                    {
                        cpuScheduler.Session();
                    }
                }
            }
            cpu.WorkingCycle();
            device.WorkingCycle();
        }

        void Clear()
        {
            cpu.Clear();
            device.Clear();
            ram.Clear();
            readyQueue.Clear();
            deviceQueue.Clear();
        }

        private SystemClock clock;
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
        private Memory ram;
    }
}
