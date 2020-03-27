using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
     partial class Calculation
    {
        public int Number3 { get; set; }
        public int Number4 { get; set; }
        public void multMath()
        {
            Console.WriteLine("The mult of two number - " + (Number3 + Number4));
        }
    }
}
