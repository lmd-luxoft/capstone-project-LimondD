using HomeAccounting.BusinessLogic.EF.Domain;
using Microsoft.EntityFrameworkCore;

namespace HomeAccounting.BusinessLogic.EF.ApplicationLogic
{
    public class DomainContext : DbContext
    {
        private readonly string _connectionString = "Host=localhost; Username=postgres; Password=admin; Database=postgres";

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Cash> Cashes { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyPriceChange> PriceChanges { get; set; }
        public DbSet<Deposit> Deposites { get; set; }

        //public DomainContext()
        //{
        //    Database.EnsureDeleted();
        //}

        public DomainContext(DbContextOptions<DomainContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>();
            modelBuilder.Entity<Bank>();
            modelBuilder.Entity<Cash>();
            modelBuilder.Entity<Operation>()
                .HasMany(p => p.Accounts);
            modelBuilder.Entity<Property>()
                .HasMany(p => p.PropertyPriceChanges);
            modelBuilder.Entity<PropertyPriceChange>();
            modelBuilder.Entity<Deposit>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
