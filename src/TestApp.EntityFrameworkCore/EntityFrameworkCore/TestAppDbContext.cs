using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TestApp.Authorization.Roles;
using TestApp.Authorization.Users;
using TestApp.MultiTenancy;

namespace TestApp.EntityFrameworkCore
{
    public class TestAppDbContext : AbpZeroDbContext<Tenant, Role, User, TestAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TestAppDbContext(DbContextOptions<TestAppDbContext> options)
            : base(options)
        {
        }

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.LogTo(System.Console.WriteLine);

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    foreach (var entityType in modelBuilder.Model.GetEntityTypes())
    {
        foreach (var property in entityType.GetProperties())
        {
            // max char length value in sqlserver
            if (property.GetMaxLength() == 67108864)
                // max char length value in postgresql
                property.SetMaxLength(10485760);
        }
    }
}



    }
}
