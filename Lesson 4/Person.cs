using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    public class Person
    {
        protected DateTime _dateOfBirth;
        public string Name;
        private int _dollarsCount;

        public int Age
        {
            get
            {
                return ((int)(DateTime.Now - _dateOfBirth).TotalDays)/ 365;
            }
        }

        
    }
}
