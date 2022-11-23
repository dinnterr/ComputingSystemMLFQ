using Queues;
using Structures;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputingSystem
{
    class MLFQ
    {
        public MLFQ()
        {
            queue = new FIFOQueue<Process, SimpleArray<Process>>[4];
        }

        public void Put (Process p)
        {
           queue[0].Put(p);
          // return queue;
        }

        public void Clear()
        {
            for (int i = 0; i < 4; i++)
            {
                queue[i].Clear();
            }
        }

       
        private FIFOQueue<Process, SimpleArray<Process>>[] queue;
    }
}
