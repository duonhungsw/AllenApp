namespace Allen.Domain.Models;

public class Role : Entity<Guid>
{
	public string RoleName { get; set; } = default!;

	public static Role Create(Guid id, string roleName)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(roleName);

		var role = new Role
		{
			Id = id,
			RoleName = roleName
		};
		return role;
	}
}
