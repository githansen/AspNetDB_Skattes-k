using AspNetDB_Skattesøk.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetDB_Skattesøk
{
    public class Database : DbContext
    {
        public Database(DbContextOptions<Database> options) : base(options)
        {
    
            Database.Migrate();

        }
        public virtual DbSet<Person> personer { get; set; }

    }
}
