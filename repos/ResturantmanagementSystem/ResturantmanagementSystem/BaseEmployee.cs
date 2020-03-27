using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantmanagementSystem
{
    public abstract class BaseEmployee
    {
        public int monthlySalary { get; set; }
        public string name { get; set; }
        public string prosetion { get; set; }
        public string number { get; set; }
        public string job_condition { get; set; }
        public string address { get; set; }

        public abstract void employeeDetails();
        public abstract void employeeSalary(int monthlySalary);
    }
}
