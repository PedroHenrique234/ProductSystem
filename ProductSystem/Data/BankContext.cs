using Microsoft.EntityFrameworkCore;

namespace ProductSystem.Data
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> options) : base(options)
        {

        }
        DbSet<BankContext> Products {  get; set; }
    }
}
