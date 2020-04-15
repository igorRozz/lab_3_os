using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_os_wf
{
    class Package
    {
        public Package(int t, int p)
        {
            Time = t;
            Priority = p;
        }
        public int Time { get; set; }
        public int Priority { get; set; }

    }
}
