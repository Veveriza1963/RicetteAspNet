using Microsoft.EntityFrameworkCore;
using RicetteDB.Models;

namespace RicetteDB.Data;

public class RicetteContext : DbContext
{
    //Tabelle
    public DbSet<Articoli> Articoli { get; set; } = null!;
    public DbSet<RicAzoto> RicAzoto { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder ModelBuilder)
    {
        base.OnModelCreating(ModelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
    {
        if (OptionsBuilder.IsConfigured) return;
        const string ConnectionString = "server=192.168.0.31;user=Gomsil;password=Gomsil123;database=RicetteDB";
        var ServerVersion = new MariaDbServerVersion(new Version(10, 3, 28));
        OptionsBuilder.UseMySql(ConnectionString, ServerVersion);
    }
}