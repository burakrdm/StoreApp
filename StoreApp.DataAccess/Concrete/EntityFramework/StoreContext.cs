using StoreApp.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.DataAccess.Concrete.EntityFramework
{
    public class StoreContext:DbContext
    {
        public StoreContext():base("ShoppingConnectionString")
        {
            Database.SetInitializer(new StoreInitializer());
            //Database.SetInitializer<StoreContext>(new DropCreateDatabaseIfModelChanges<StoreContext>());
        }

        public DbSet <Product> Ptoducts { get; set; }
        public DbSet <Category> Categories { get; set; }

        public DbSet <Order> Orders { get; set; }
        public DbSet <AccountPerson> AccountPersons { get; set; }
        public DbSet <AccountRole> AccountRoles { get ; set; }
        public DbSet <AccountUser> AccountUsers { get ; set; }
    }
}
