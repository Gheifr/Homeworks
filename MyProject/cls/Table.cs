using System;
using System.Collections.Generic;
using System.Text;

namespace cls
{
    public class Table
    {
        public int TblNumber { get; private set; }
        public int Guests { get; private set; }

        private int orderNumber = SetOrderNum();
        public List<string> Order { get; private set; }
        
        public bool OrderExists { get; private set; }

        public string Employee { get; private set; }


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
