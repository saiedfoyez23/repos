using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantmanagementSystem
{
    public abstract class BaseFood
    {
        public string FoodName { get; set; }
        public string Discription { get; set; }
        public float price { get; set; }

        public abstract void foodDetails();
        public abstract void priceDetails();
    }
}
