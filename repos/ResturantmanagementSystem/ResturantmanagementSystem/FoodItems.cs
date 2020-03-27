using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantmanagementSystem
{
    class FoodItems:BaseFood
    {
        public override void foodDetails()
        {
            Console.WriteLine("Food_name: " + FoodName);
            Console.WriteLine("Food_Discription: " + Discription);
            
        }
        public override void priceDetails()
        {
            Console.WriteLine("Food_Price_with_discount: " + ((price*27)/100));
        }
    }
}
