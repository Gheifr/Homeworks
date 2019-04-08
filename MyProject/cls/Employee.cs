using System;
using System.Collections.Generic;
using System.Text;

namespace cls
{
    class Employee: Person
    {
        public string Position { get; private set; }
        public int AccessLevel { get; private set; }

        private double Salary;

        public int userID { get; private set; }

        public void SetSalary(double Salary)
        {
            this.Salary = Salary;
        }
        public double SetSalary()
        {
            return Salary;
        }

    }
}
