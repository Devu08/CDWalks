using CDWalks.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CDWalks.API.Data
{
    public class CDWalksDbContext:DbContext
    {
        public CDWalksDbContext(DbContextOptions<CDWalksDbContext>options):base(options)
        {

        }
        public DbSet<Region>Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
