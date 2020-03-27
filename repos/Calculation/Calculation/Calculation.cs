using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    partial class Calculation
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public void addMath()
        {
            Console.WriteLine("The Add of two number - "+(Number1+Number2));
        }
    }
}
