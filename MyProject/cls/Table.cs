using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using static cls.Tbl;

namespace cls
{
    public class Tbl:ISaveRecord
    {
        public delegate void OrderChange(string change);
       
        public event OrderChange OrderChanged;

        public int TblNumber { get; private set; }
        public int Guests { get; private set; }

        public ObservableCollection<string> Order = new ObservableCollection<string>();


        public bool OrderExists { get; private set; }

        internal long _orderId { get;  set; }

        public Tbl(int tableNumber)
        {
            this.TblNumber = tableNumber;
            _orderId++;
            OrderChanged += SaveChangesToOrder; //is this a good idea to subscribe to event when instance of a class is created?
        }

        public int GetTblNum()
        {
            return this.TblNumber;
        }

        public ObservableCollection<string> GetOrder()
        {
            return Order;
        }

        public void AddOrderItem(string _item)
        {
            if (Order.Count == 1)
            {
                if (Order[0] == "Empty by now")
                {
                    Order[0] = _item;
                    OrderChanged(_item);
                }
                else
                {
                    Order.Add(_item);
                    OrderChanged(_item);
                }
                
            }
            Order.Add(_item);
            OrderChanged(_item);
        }

        public void SaveChangesToOrder(string _record)
        {

            using (ClsDBContext db = new ClsDBContext())
            {
                db.Entities.Add($" {DateTime.Now}: Item {(char)34}{_record}{(char)34} was added to order No {_orderId}");
                db.SaveChanges();
            }
            
        }

        public void ShowOrderChanges(long orderID)
        {
            using (ClsDBContext db = new ClsDBContext())
            {
                string num = orderID.ToString(); 
                foreach(string line in db.Entities)
                {
                    if (line.Substring(line.Length -num.Length, num.Length) == num)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}
