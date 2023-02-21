using Microsoft.EntityFrameworkCore;
using NW2.Areas.Admin.Models;

namespace NW2.Models
{
    public class DataContext : DbContext

    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Menu> Menus { get; set; }

        public DbSet<Fact> Facts { get; set; }
        public DbSet<Animals> Animalss { get; set; }
        public DbSet<Services> Servicess { get; set; }
        public DbSet<Visiting> Visitings { get; set; }

        public DbSet<AdminMenu> AdminMenus { get; set; }
    }
}
