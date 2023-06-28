using JsonColumnBD.Models;
using Microsoft.EntityFrameworkCore;

namespace JsonColumnBD.Context
{
    public class DbContextSales:DbContext
    {
        public DbContextSales(DbContextOptions<DbContextSales> options) : base(options)
        {
        }
        public DbSet<Sales> sales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sales>().OwnsOne(sale => sale.Customer, c =>
            {
                c.ToJson();
                c.OwnsOne(cus => cus.DireccionCus);
            });
        }
    }
}
