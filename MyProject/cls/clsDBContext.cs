using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace cls
{
    class ClsDBContext : DbContext
    {

        public ClsDBContext()
            : base("DbConnection")
        { }

        public DbSet<OrderCls> Entities { get; set; }
    }
}
