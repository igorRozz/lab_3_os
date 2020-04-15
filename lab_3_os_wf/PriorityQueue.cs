using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_os_wf
{
    class PriorityQueue
    {
        public int size;
        public int avt = 0;
        public int dt = 0;
        public int number = 0;
        List<Package> pq = new List<Package>();
        public PriorityQueue(int size)
        {
            this.size = size;
        }
        public void tick()
        {
            avt += pq.Count;
            if (pq.Count == 0)
            {
                dt++;
            }
            else
            {
                pq[0].Time--;
                if (pq[0].Time == 0)
                {
                    pq.RemoveAt(0);
                }
            }
        }

        public void add(Package pc)
        {
            if (pq.Count < size)
            {
                number++;
                int idx = 0;
                for (; idx < pq.Count; idx++)
                {
                    if (pq[idx].Priority > pc.Priority)
                    {
                        break;
                    }
                }
                pq.Insert(idx, pc);
            }
        }

    }
}
