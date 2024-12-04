using System.Security.Claims;

namespace Allen.Application.Helper.Jwt;

public class TokenService : ITokenService
{
	public string GenerateAccessToken(IEnumerable<Claim> claims)
	{
		throw new NotImplementedException();
	}

	public string GenerateRefreshToken()
	{
		throw new NotImplementedException();
	}

	public ClaimsPrincipal ValidateToken(string token)
	{
		throw new NotImplementedException();
	}
}
