using GenericTestDomain.Model;
using GenericTestDomain.Service;
using Microsoft.EntityFrameworkCore;

namespace GenericTestDataAccess
{
    public class GenericTestContext : DbContext
    {
        private readonly IConnectionStringProvider _connectionStringProvider;
        public GenericTestContext(DbContextOptions<GenericTestContext> options, IConnectionStringProvider connectionStringProvider)
            : base(options)
        {
            _connectionStringProvider = connectionStringProvider;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(_connectionStringProvider.GetConnectionString());
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            #region Car Model Attributes
            modelBuilder.Entity<Car>().HasKey(x=>x.Id);
            modelBuilder.Entity<Car>().Property(x => x.Name);
            modelBuilder.Entity<Car>().Property(x => x.Brand);
            modelBuilder.Entity<Car>().Property(x => x.Model);
            modelBuilder.Entity<Car>().Property(x => x.TopSpeed);
            #endregion
            #region Person Model Attributes
            modelBuilder.Entity<Person>().HasKey(x => x.Id);
            modelBuilder.Entity<Person>().Property(x=>x.Name);
            modelBuilder.Entity<Person>().Property(x=>x.FamilyName);
            modelBuilder.Entity<Person>().Property(x=>x.Age);
            modelBuilder.Entity<Person>().Property(x => x.Phone);
            #endregion
            #region Organizaion Model Attributes
            modelBuilder.Entity<Organization>().HasKey(x => x.Id);
            modelBuilder.Entity<Organization>().Property(x=>x.Name);
            modelBuilder.Entity<Organization>().Property(x=>x.Field);
            modelBuilder.Entity<Organization>().Property(x=>x.Address);
            modelBuilder.Entity<Organization>().Property(x => x.Personnel);
            #endregion
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Organization> Organizations { get; set; }
    }
}
