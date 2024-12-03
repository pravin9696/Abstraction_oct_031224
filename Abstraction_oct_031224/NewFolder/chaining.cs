using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_oct_031224.NewFolder
{
   class AA
    {
        int a;
        public AA()
        {
            a = 1000;
            Console.WriteLine("AA constructor");
        }
    }
    class BB:AA
    {
        int b;
        public BB()
        {
            
            b = 2000;
            Console.WriteLine("BB constructor");
        }
    }
}
