using Allen.Application.Dtos.Customer;
using Microsoft.AspNetCore.Authorization;

namespace Allen.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerController(ICustomerService customerService) : ControllerBase
{
	
	[HttpPost("Login")]
	public async Task<Customer> Login([FromBody] LoginModel loginModel)
	{
		var account = await customerService.LoginAsync(loginModel);
		return account!;
	}
	[HttpPost("Register")]
	public async Task<bool> Register([FromBody] RegistrationModel model)
	{
		var register = await customerService.RegisterAsync(model);
		return register;
	}
}
	