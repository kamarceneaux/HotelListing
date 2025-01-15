using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HoteListingDbContext : DbContext
    {
        public HoteListingDbContext(DbContextOptions options) : base(options)
        {

        }

        // Add the entities to the database
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Coutries { get; set; }

    }
}
