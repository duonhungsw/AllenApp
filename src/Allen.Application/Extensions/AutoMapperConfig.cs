namespace Allen.Application.Extensions;

public static class AutoMapperConfig
{
	public static IMapper Initial()
	{
		var mapperConfiguration = new MapperConfiguration(cfg =>
		{
			cfg.AddProfile<CustomerMappingProfile>();
		});

		return mapperConfiguration.CreateMapper();
	}
}
