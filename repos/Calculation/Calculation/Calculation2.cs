using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    partial class Calculation
    {
        public float Number5 { get; set; }
        public float Number6 { get; set; }
        public int add { get; set; }
        public void divMath()
        {
            Console.WriteLine("The div of two number - " + (Number5/Number6));
        }

        public void PrintAdd(params int[] number)
        {

            for (int i = 0; i < number.Length; i++)
            {
                add += number[i];
            }
            Console.WriteLine("Multipul value add -" + add);
        }
    }
}
