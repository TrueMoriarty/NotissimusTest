using DAL.EfClasses;
using Microsoft.EntityFrameworkCore;

namespace DAL.EfCode;

public class NotissimusContext : DbContext
{
    public DbSet<Storage> Storages { get; set; }

    public NotissimusContext() { }
    public NotissimusContext(DbContextOptions<NotissimusContext> option) : base(option) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Notissimusdb;Username=pgadmin;Password=pgadmin");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Storage>().Property(s => s.Id).UseIdentityAlwaysColumn();

        modelBuilder.Entity<Storage>().HasData(
            new Storage { Id = 1, Text = "The Great Dictator" },
            new Storage { Id = 2, Text = "Cinema Paradiso" },
            new Storage { Id = 3, Text = "The Lives of Others" },
            new Storage { Id = 4, Text = "Grave of the Fireflies" },
            new Storage { Id = 5, Text = "Paths of Glory" },
            new Storage { Id = 6, Text = "Django Unchained" },
            new Storage { Id = 7, Text = "The Shining" },
            new Storage { Id = 8, Text = "WALL·E" },
            new Storage { Id = 9, Text = "American Beauty" },
            new Storage { Id = 10, Text = "The Dark Knight Rises" },
            new Storage { Id = 11, Text = "Princess Mononoke" },
            new Storage { Id = 12, Text = "Aliens" },
            new Storage { Id = 13, Text = "Oldboy" },
            new Storage { Id = 14, Text = "Once Upon a Time in America" },
            new Storage { Id = 15, Text = "Witness for the Prosecution" },
            new Storage { Id = 16, Text = "Das Boot" },
            new Storage { Id = 17, Text = "Citizen Kane" },
            new Storage { Id = 18, Text = "North by Northwest" },
            new Storage { Id = 19, Text = "Vertigo" });

        base.OnModelCreating(modelBuilder);
    }


}