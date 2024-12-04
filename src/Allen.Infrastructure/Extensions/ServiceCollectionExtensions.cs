using Allen.Infrastructure.Data.Interceptors;

namespace Allen.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddInfrastructureService
	(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddDbContext<ApplicationDbContext>((sp, opts) =>
		{
			opts.AddInterceptors(new AuditableEntityInterceptor());
			opts.UseSqlServer(configuration.GetConnectionString("Database"));
		});


		return services;
	}
}
