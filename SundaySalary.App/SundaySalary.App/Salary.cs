using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SundaySalary.App
{
    class Salary
    {
        public string EmployeeName { get; set; }
        public double BasicAmount { get; set; }
        public double PercentOfHouseRant { get; set; }
        public double PercentOfMedicalAllowance { get; set; }

        public double GetHouseRant()
        {
            return (BasicAmount*PercentOfHouseRant)/100;
        }

        public double GetMedicalAllowance()
        {
            return (BasicAmount*PercentOfMedicalAllowance)/100;
        }

        public double GetTotal()
        {
            return BasicAmount + GetHouseRant() + GetMedicalAllowance();
        }
            
    }
}
