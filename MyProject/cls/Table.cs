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

        public string Employee { get; private set; }


        private long orderId { get; set; }

        public Tbl(int tableNumber)
        {
            this.TblNumber = tableNumber;
            OrderChanged += Save; //is this a good idea to subscribe to event when instance of a class is created?
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

        public void Save(string _record)
        {

            using (ClsDBContext db = new ClsDBContext())
            {
                db.Entities.Add(_record);
                db.SaveChanges();
            }
            
            
        }
    }
}
