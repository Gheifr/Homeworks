using System;
using System.Collections.Generic;
using System.Text;

namespace cls
{
    public class Guest:Person
    {
        public int Visits;
        public string LoyaltyLevel;

        private void UpdateLoyaltyLevel(int visitsCount)
        {
            if (visitsCount > 49)
                LoyaltyLevel = "VIP";
            else if (visitsCount > 29)
                LoyaltyLevel = "Platinum";
            else if (visitsCount > 19)
                LoyaltyLevel = "Gold";
            else
                LoyaltyLevel = "Regular";
        }


    }
}
