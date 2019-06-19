using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace cls
{
    
    public class OrderCls
    {
        
        public long id { get; set; }

        private string record { get; set; }

        private DateTime timeChanged { get; set; }

        public OrderCls(DateTime TimeChanged, long Id, string Record)
        {
            record = Record;
            timeChanged = TimeChanged;
            id = Id;
        }
        
    }
}
