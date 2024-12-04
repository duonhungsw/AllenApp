namespace Allen.Application.Mappings;

public class CustomerMappingProfile : Profile
{
	public CustomerMappingProfile()
	{
		CreateMap<LoginModel, Customer>()
			.ForMember(l => l.Name, options => options.MapFrom(m => m.UserNameOrEmail))
			.ForMember(l => l.Email, options => options.MapFrom(m => m.UserNameOrEmail))
			.ForMember(l => l.HashPassword, options => options.MapFrom(m => m.Password));

		CreateMap<RegistrationModel, Customer>()
			.ForMember(l => l.HashPassword, options => options.MapFrom(m => m.Password));
	}
}
