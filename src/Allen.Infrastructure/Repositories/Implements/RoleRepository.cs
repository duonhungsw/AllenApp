namespace Allen.Infrastructure.Repositories.Implements;

public class RoleRepository : GenericRepository<Role>, IRoleRepository
{
	public RoleRepository(ApplicationDbContext context) : base(context) { }

}
