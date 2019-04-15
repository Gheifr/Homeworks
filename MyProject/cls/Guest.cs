using System;
using System.Collections.Generic;
using System.Text;

namespace cls
{
    public class Guest:Person
    {
        public int Visits;
        private string _loyaltyLevel;
        
        public void UpdateLoyaltyLevel(int visitsCount)
        {
            if (visitsCount > 49)
                _loyaltyLevel = "VIP";
            else if (visitsCount > 29)
                _loyaltyLevel = "Platinum";
            else if (visitsCount > 19)
                _loyaltyLevel = "Gold";
            else
                _loyaltyLevel = "Regular";
        }


    }
}
