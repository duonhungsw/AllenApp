using System.Security.Claims;

namespace Allen.Application.Services.Interface;

public interface ITokenService
{
	string GenerateAccessToken(IEnumerable<Claim> claims);
	string GenerateRefreshToken();
	ClaimsPrincipal ValidateToken(string token);

}
