using Allen.Application.Services.Interfaces;

namespace Allen.Application.Services.Implements;

public class RoleService(IRoleRepository roleRepository) : IRoleService
{
	public async Task<Role?> GetRoleByRoleName(string RoleName)
	{
		throw new NotImplementedException();
	}
}
