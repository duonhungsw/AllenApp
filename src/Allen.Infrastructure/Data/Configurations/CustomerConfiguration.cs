namespace Allen.Infrastructure.Data.Configurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
	public void Configure(EntityTypeBuilder<Customer> builder)
	{
		builder.HasKey(c => c.Id);
		builder.HasOne<Role>()
			.WithMany()
			.HasForeignKey(c => c.RoleId)
			.IsRequired();
		builder.Property(c => c.Name).HasMaxLength(100).IsRequired();
		builder.Property(c => c.HashPassword).IsRequired();
		builder.Property(c => c.Email).HasMaxLength(100);
		builder.HasIndex(c => c.Email).IsUnique();
	}
}
