namespace Allen.Infrastructure.Repositories.Implements;

public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
{
	public CustomerRepository(ApplicationDbContext context) : base(context) { }

}
