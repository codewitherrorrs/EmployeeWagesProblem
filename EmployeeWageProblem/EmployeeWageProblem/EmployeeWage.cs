using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class EmployeeWage
    {
        int fullTime = 1;
        int empHrs = 0;
        int empRateHrs = 20;
        int empwage = 0;
        public void Employee()
        {
            Random random = new Random();
            int check = random.Next(2);

            if (check == fullTime)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }

            empwage = empRateHrs * empHrs;
            Console.WriteLine($"Employee Wage is : {empwage}");
        }
    }
}
