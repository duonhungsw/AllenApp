namespace Allen.Application.Services.Interfaces;

public interface ICustomerService
{
	Task<Customer?> LoginAsync(LoginModel loginModel);
	Task<bool> RegisterAsync(RegistrationModel Regismodel);
}
