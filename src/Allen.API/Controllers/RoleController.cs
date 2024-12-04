namespace Allen.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RoleController(ApplicationDbContext context) : ControllerBase
{
	[HttpPost]
	public async Task AddRole([FromBody] AddRoleDto roleDto)
	{
		var role = new Role
		{
			Id = Guid.NewGuid(),
			RoleName = roleDto.RoleName!
		};

		await context.Roles.AddAsync(role);
		context.SaveChanges();
	}
}
