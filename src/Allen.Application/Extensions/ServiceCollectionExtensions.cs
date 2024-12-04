using Allen.Application.Services.Implements;
namespace Allen.Application.Extensions;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddSingleton<IConfiguration>(configuration);
		services.AddJwtAuthentication(configuration);

		services.AddAuthorization();

		services.AddScoped<ICustomerRepository, CustomerRepository>();
		services.AddScoped<IRoleRepository, RoleRepository>();
		services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
		services.AddScoped<ITokenService, JwtTokenService>();
		services.AddAutoMapper(typeof(AutoMapperConfig));
		return services;
	}
}
