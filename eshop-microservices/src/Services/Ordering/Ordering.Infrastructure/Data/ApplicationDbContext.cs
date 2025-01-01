using System.Reflection;
using Ordering.Application.Data;

namespace Ordering.Infrastructure.Data;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Product> Product => Set<Product>();
    public DbSet<Order> Order => Set<Order>();
    public DbSet<OrderItem> OrderItems => Set<OrderItem>();

    public DbSet<Product> Products => throw new NotImplementedException();

    public DbSet<Order> Orders => throw new NotImplementedException();

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
}
