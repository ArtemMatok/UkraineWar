using Microsoft.EntityFrameworkCore;
using UkraineWar.Models;

namespace UkraineWar.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MilitaryEquipment> MilitaryEquipments { get; set; }
    }
}
