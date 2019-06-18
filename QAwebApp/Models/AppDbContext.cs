using Microsoft.EntityFrameworkCore;


namespace QAwebApp.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)

        {

        }

        public DbSet<FormModel> Forms { get; set; }
        public DbSet<UnitResponsibleModel> UnitResponsibleModel { get; set; }

        public DbSet<UserModel> Users { get; set; }

        public DbSet<AdminModel> Admins { get; set; }

    }
}
