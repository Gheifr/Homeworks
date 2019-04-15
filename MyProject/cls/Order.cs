using System;
using System.Collections.Generic;
using System.Text;

namespace cls
{
    public class Order
    {
        public readonly int OrderNumber = SetOrderNum();
        public string Employee;
        

        public string FormOrder()
        {
            return "0"; //have some questions - #3
        }

        internal static int SetOrderNum()
        {
            int lastOrderNum = 1; //get last order number from storage
            return lastOrderNum + 1;
        }


    }
}
