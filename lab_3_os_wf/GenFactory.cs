using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_os_wf
{
    class GenFactory
    {
        public static IEnumerator<Package> getGenerator(int minTime, int maxTime,
               int minPriority, int maxPriority)
        {
            Random rnd = new Random();
            while (true)
            {
                yield return new Package(rnd.Next(minTime, maxTime),
                    rnd.Next(minPriority, maxPriority));
            }
        }

    }
}
