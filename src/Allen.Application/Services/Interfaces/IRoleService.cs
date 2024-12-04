namespace Allen.Application.Services.Interfaces;

public interface IRoleService
{
	Task<Role?> GetRoleByRoleName(string RoleName);

}
