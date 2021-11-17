using Microsoft.EntityFrameworkCore;

namespace Elections.Data
{
    public class ElectionsContext : DbContext
    {
        internal object IecParties;

        public ElectionsContext(DbContextOptions<ElectionsContext> opt) : base(opt)
        {
            
        }

       //Basically the below is saying we want to represent IecParties
       // as DbSet > tablename NovElections
        public DbSet<IecParties> NovElections { get; set; }
    }
}