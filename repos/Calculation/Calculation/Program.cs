using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            //partial class

            Calculation calculation = new Calculation()
            {
                Number1 = 23,
                Number2 = 34,
                Number3=45,
                Number4=98,
                Number5=1234f,
                Number6= 23.90f
            };
            calculation.addMath();
            calculation.multMath();
            calculation.divMath();
            calculation.PrintAdd(1,2,3,4,5,6,7,8,9,10,11,12,13,14,1,5,1,6);

            Console.ReadLine();


        }
        //void Print(Params int[] number){}
        // array collection two kind of 1. Non-Generic 2.Generic 
        //Non-Generic-> ArrayList,HashTable,SortedList,stack,queue
        //Generic->List,Dictionary,SortedList,stack,queue
    }
}
