using System;
using System.Windows;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using static cls.Tbl;
using System.Timers;

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

        private System.Timers.Timer timeOpened;

        public Tbl(int tableNumber)
        {
            this.TblNumber = tableNumber;
            _orderId++;

            timeOpened = new System.Timers.Timer(7200000);
            timeOpened.Interval = 7200000; // do I need to set this additionaly if the timer is already created for some time?
            timeOpened.Elapsed += markOutstandingTable;
            timeOpened.AutoReset = false;

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
                    if (timeOpened.Enabled == false && Order[0] != "Empty by now")
                        timeOpened.Enabled = true; //timer is enabled when some order is added, no need to use it with blank order
                }
                else
                {
                    Order.Add(_item);
                    OrderChanged(_item);
                    if (timeOpened.Enabled == false)
                        timeOpened.Enabled = true;
                }
                
            }
            Order.Add(_item);
            OrderChanged(_item);
            if (timeOpened.Enabled == false)
                timeOpened.Enabled = true;
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

        private void markOutstandingTable(object sender, ElapsedEventArgs e)
        {
            //when table is open for more than two hours - it will be marked with red color
        }
    }
}
