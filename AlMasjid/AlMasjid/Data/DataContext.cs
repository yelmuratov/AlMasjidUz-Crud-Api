using AlMasjid.Entities;
using Microsoft.EntityFrameworkCore;

namespace AlMasjid.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Almasjid>Mosques { get; set; }
    }


}
