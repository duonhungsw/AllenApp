using Allen.Common.Exceptions.Handler;
namespace Allen.API.Extensions;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddApiServices(this IServiceCollection services)
	{

		services.AddScoped<ICustomerService, CustomerService>();
		services.AddScoped<IRoleService, RoleService>();

		services.AddExceptionHandler<CustomerExceptionHandler>();
		return services;
	}
	public static WebApplication UseApiServices(this WebApplication app)
	{
		
		app.UseExceptionHandler(options => { });

		return app;
	}
}
