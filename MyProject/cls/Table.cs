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
                OrderCls orderRecord = new OrderCls(DateTime.Now, _orderId, _record);
                db.Entities.Add(orderRecord);
                db.SaveChanges();
            }
            
        }

        public void ShowOrderChanges(long orderID)
        {
            using (ClsDBContext db = new ClsDBContext())
            {
                ; 
                foreach(OrderCls line in db.Entities)
                {
                    if (line.id == orderID)
                    {
                        Console.WriteLine(line.ToString());
                    }
                }
            }
        }
    }
}
