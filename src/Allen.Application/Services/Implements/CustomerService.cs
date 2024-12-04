using System.Security.Claims;

namespace Allen.Application.Services.Implements;

public class CustomerService(ICustomerRepository customerRepository, IRoleRepository roleRepository, ITokenService token, IMapper mapper)
							: ICustomerService
{
	public Task<Customer?> LoginAsync(LoginModel loginModel)
	{
		throw new NotImplementedException();
	}

	public Task<bool> RegisterAsync(RegistrationModel Regismodel)
	{
		throw new NotImplementedException();
	}
}
