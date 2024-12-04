using Microsoft.EntityFrameworkCore;

namespace Allen.Application.Data;

public interface IApplicationDbContext
{
	public DbSet<Customer> Customers { get; set; }
	public DbSet<Role> Roles { get; set; }
	Task<int> SaveChangesAsync();
}
