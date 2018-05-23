using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WJK_Inventory.Models
{
    public class ItemDbContext : DbContext
    {
        public ItemDbContext():base("WjkDb")
        {
            
        }
        public DbSet<Item> Items { get; set; }

    }
}