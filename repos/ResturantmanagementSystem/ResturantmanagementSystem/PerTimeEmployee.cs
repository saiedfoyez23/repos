using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantmanagementSystem
{
    class PerTimeEmployee:BaseEmployee
    {

        public override void employeeDetails()
        {
            Console.WriteLine("Employee_name: " + name);
            Console.WriteLine("Employee_prosetion: " + prosetion);
            Console.WriteLine("Employee_number: " + number);
            Console.WriteLine("Employee_job_condition: " + job_condition);
            Console.WriteLine("Employee_address" + address);

        }

        public override void employeeSalary(int monthlySalary)
        {

            Console.WriteLine("Employee_prosetion- " + prosetion + " " + "Employee_mounth_salary-" + monthlySalary);
        }

    }
}
