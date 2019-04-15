using System;
using System.Collections.Generic;
using System.Text;

namespace cls
{
    public class Person
    {
    public string FName { get; private set; }
    public string LName { get; private set; }
    public string Phone{ get; private set; }
    public string Address{ get; private set; }
    public string Email{ get; private set; }

    private DateTime dateOfBirth;
    public string Age { get; private set; }
    
        public string GetAge()
        {
            System.DateTime dateNow = DateTime.Now;
            return (dateNow.Year - dateOfBirth.Year).ToString();
        }

    }
}
