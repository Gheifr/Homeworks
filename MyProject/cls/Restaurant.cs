using System;

namespace cls
{
       public class Restaurant
    {
        public string Name;
        public string Location;
        public string Address;
        public string PhoneNumber;


        public void SetAddress(string Address)
        {
            this.Address = Address;
        }
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public void SetPhoneNumber(string Number)
        {
           PhoneNumber = Number;
        }
        public void SetLocation(string Location)
        {
            this.Location = Location;
        }

    }
}
