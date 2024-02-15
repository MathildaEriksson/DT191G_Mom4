using Microsoft.EntityFrameworkCore;
using DT191G_Mom4.Models;

namespace DT191G_Mom4.Data;

public class MusicDbContext : DbContext
{
    public MusicDbContext(DbContextOptions<MusicDbContext> options) : base(options)
    {
    }

    public DbSet<Song> Songs { get; set; }
    public DbSet<Category> Categories { get; set; }

}
