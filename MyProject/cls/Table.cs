using System;
using System.Collections.Generic;
using System.Text;

namespace cls
{
    public class Tbl
    {
        public int TblNumber { get; private set; }
        public int Guests { get; private set; }

        private int orderNumber = SetOrderNum();

        public string Order { get; private set; }

        public bool OrderExists { get; private set; }

        public string Employee { get; private set; }


        public Tbl(int tableNumber)
        {
            this.TblNumber = tableNumber;
            this.Order = null;
        }

        internal static int SetOrderNum()
        {
            int lastOrderNum = 1; //get last order number from storage
            return lastOrderNum + 1;
        }

        public int GetTblNum()
        {
            return this.TblNumber;
        }

        public string GetOrder()
        {
            return this.Order;
        }

        public void AddOrderItem(string _item)
        {
            if (this.Order == null)
                this.Order += _item;
            else
                this.Order += "|"+_item;
        }
    }
}
