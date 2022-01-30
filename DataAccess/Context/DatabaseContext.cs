using Entities;
using Entities.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace DataAccess.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {

        }

        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Harcama> Harcamalar { get; set; }
        public DbSet<Izin> Izinler { get; set; }
        public DbSet<Odeme> Odemeler { get; set; }
        public DbSet<Sirket> Sirketler { get; set; }
        public DbSet<SirketYoneticisi> SirketYoneticileri { get; set; }
        public DbSet<UyelikPaketi> UyelikPaketleri { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }
        public DbSet<Zimmet> Zimmetler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("KolayIkDbConnnectionString");
                optionsBuilder.UseSqlServer(connectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

    }
}
