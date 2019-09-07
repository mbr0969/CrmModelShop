using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;

namespace CrmBL.Model {
    public class CrmContext : DbContext {

        public CrmContext() :base("CRMConnection") {}

        public DbSet<Check> Checks { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sell> Sells { get; set; }
        public DbSet<Seller> Sellers { get; set; }

    }
}
