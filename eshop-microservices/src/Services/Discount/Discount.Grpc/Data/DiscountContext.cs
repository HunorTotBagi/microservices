namespace Discount.Grpc.Data;

public class DiscountContext : DbContext
{
    public DbSet<Coupon> Coupons { get; set; } = default!;

	public DiscountContext(DbContextOptions<DiscountContext> options) : base(options)
	{

	}
}
