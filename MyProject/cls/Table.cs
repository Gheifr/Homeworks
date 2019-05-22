using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace cls
{
    public class Tbl:ISaveRecord
    {
        public int TblNumber { get; private set; }
        public int Guests { get; private set; }

        private int orderNumber = SetOrderNum();

        public ObservableCollection<string> Order = new ObservableCollection<string>();


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
            return Order.ToList;
        }

        public void AddOrderItem(string _item)
        {
            
                Order.Add(_item);
                Save($"User {this.Employee} added record {this.Order}");

        }

        public void Save(string _record)
        {
            //some System.IO.TextWriter will write all changes to the file
        }
    }
}
