using Microsoft.EntityFrameworkCore;
using ProductSystem.Models;

namespace ProductSystem.Data
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> options) : base(options)
        {

        }
        DbSet<ProductModel> Products {  get; set; }
    }
}
