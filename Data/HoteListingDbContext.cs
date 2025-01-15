using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HoteListingDbContext : DbContext
    {
        public HoteListingDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
