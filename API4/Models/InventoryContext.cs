using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API4.Models
{
    public partial class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options)
           : base(options)
        {
        }

        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }

    }
}
