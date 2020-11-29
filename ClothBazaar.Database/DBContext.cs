using ClothBazar.Entities;//add from reference
using System.Data.Entity;

namespace ClothBazaar.Database
{
    class DBContext : DbContext
    {
        public DBContext():base("ClothBazarConnection")//tell to dbcontext about connectionstring name.
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
 