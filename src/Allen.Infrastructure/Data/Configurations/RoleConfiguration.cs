namespace Allen.Infrastructure.Data.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
	public void Configure(EntityTypeBuilder<Role> builder)
	{
		builder.HasKey(x => x.Id);
		builder.Property(x => x.RoleName).HasMaxLength(20).IsRequired();
	}
}
