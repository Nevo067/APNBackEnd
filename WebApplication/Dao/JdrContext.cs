using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore;
using WebApplication.Model;

namespace WebApplication.Dao
{
    public class JdrContext:DbContext
    {
        public DbSet<Jdr>JdrTable{get;set;}
        public DbSet<Membre>MembreTable { get; set; }
        public DbSet<Objet>ObjetTable { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            //base.OnConfiguring(optionsBuilder);
            
            optionsBuilder.UseMySQL("Server=localhost;port=3306;Database=dialogue;Uid=root;Pwd=;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Objet>()
                .Property(S => S.val)
                .HasDefaultValue("1d1");
            
            modelBuilder.Entity<Membre>()
                .HasOne<Jdr>(s => s.Jdr)
                .WithOne(s => s.Membre)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}