namespace Discount.Grpc.Data;

public class DiscountContext : DbContext
{
    public DbSet<Coupon> Coupons { get; set; } = default!;

	public DiscountContext(DbContextOptions<DiscountContext> options) : base(options)
	{
	}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Coupon>().HasData(
            new Coupon { Id = 1, ProductName = "IPhone X", Description = "IPhone Discount", Amount = 150},
            new Coupon { Id = 2, ProductName = "Samsung Galaxy S24", Description = "Samsung Discount", Amount = 100}
        );
    }
}
