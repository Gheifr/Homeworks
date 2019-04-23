using System;
using System.Collections.Generic;
using System.Text;

namespace cls
{
    public class Tbl:ISaveRecord
    {
        public int TblNumber { get; private set; }
        public int Guests { get; private set; }

        private int orderNumber = SetOrderNum();

        public bool OrderExists { get; private set; }

        public string Employee { get; private set; }

        private List<string> order= new List<string>();

        public List<string> Order
        {
            get
            {
                return order;
            }
            set
            {
                order = value;
            }
        }

        public Tbl(int tableNumber)
        {
            this.TblNumber = tableNumber;
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

        public List<string> GetOrder()
        {
            return this.order;
        }

        public void AddOrderItem(string _item)
        {
            if (order == null)
            {
                order.Add("Nothing entered");
                Save($"User {this.Employee} added record {this.Order}");
            }
            else
            {
                order.Add(_item);
                Save($"User {this.Employee} added record {this.order}");
            }
        }

        public void Save(string _record)
        {
            //some System.IO.TextWriter will write all changes to the file
        }
    }
}
