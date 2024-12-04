namespace Allen.Domain.Models;

public class Customer : Entity<Guid>
{
	public string Name { get; private set; } = default!;
	public string Email { get; private set; } = default!;
	public string HashPassword { get; set; } = default!;
	public string? Avatar { get; private set; } 
	public string? BirthDay { get; private set; }
	public Guid RoleId { get; set; } = default!;

	public static Customer Create(Guid id, string password, string name, string email, Guid roleId)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(name);
		ArgumentException.ThrowIfNullOrWhiteSpace(email);
		var customer = new Customer
		{
			Id = id,
			Name = name,
			HashPassword = PasswordHasher.HashPasswordPBKDF2(password),
			Email = email,
			RoleId = roleId
		};

		return customer;
	}
}
