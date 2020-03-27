using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantmanagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                name = "Saied ahammed Foyez",
                prosetion = "Manager",
                number = "01842206221",
                monthlySalary = (600000/12),
                address = "217/A/1,Mirpur,Dhaka-1216",
                job_condition = "Full Time",

            };


            employee.employeeDetails();
            employee.employeeSalary(employee.monthlySalary);

            PerTimeEmployee perTimeEmploye = new PerTimeEmployee()
            {
            name = "Saied Ahammed",
            prosetion = "intern",
            number = "01534306908",
            monthlySalary = (200*78*12),
            job_condition = "per_time_employee",
            address = "Mirpur,Dhaka-1200"
            };
            perTimeEmploye.employeeDetails();
            perTimeEmploye.employeeSalary(perTimeEmploye.monthlySalary);

            FoodItems foodItems = new FoodItems()
            {
                FoodName = "Berger",
                Discription = "Get one And Buy One",
                price= 123243.90f
            };
            foodItems.foodDetails();
            foodItems.priceDetails();
            Console.ReadLine();
        }
    }
}
