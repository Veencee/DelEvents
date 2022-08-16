using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTask
{
    internal class Completed
    {
        //public delegate void (int name);
       public delegate void Progress(int cyclesCompleted );
       public static void clockCycles(Progress p)
        {
            for (int i = 0; i < 10000; i++)
            {
                var cycles = i.ToString();   
                p(i);
            }
        }
    }
}
