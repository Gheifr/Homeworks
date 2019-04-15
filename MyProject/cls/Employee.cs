using System;
using System.Collections.Generic;
using System.Text;

namespace cls
{
    class Employee: Person
    {
        public string Position { get; private set; }
        public int AccessLevel { get; private set; }

        private double _salary;

        public int userID { get; private set; }

        public void SetSalary(double salary)
        {
            this._salary = salary;
        }
        public double GetSalary()
        {
            return _salary;
        }

    }
}
