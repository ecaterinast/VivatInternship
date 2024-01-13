using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection.Metadata;
using VivatInternship.Backend.Models;

namespace VivatInternship.Backend.Data.DbModel
{
     public class BasketContext : DbContext
     {
          private readonly string _connectionString;

          public BasketContext(DbContextOptions<BasketContext> options) :
              base(options)
          {

          }
          public virtual DbSet<Basket> Baskets { get; set; }
          //
          public virtual DbSet<Item> Items { get; set; }
          public virtual DbSet<User> Users { get; set; }

          protected override void OnModelCreating(ModelBuilder modelBuilder)
          {
               modelBuilder.ApplyConfigurationsFromAssembly(typeof(BasketContext).Assembly);
          }
          /*
           * protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sql server database
        options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
    }*/
    
     }
}
