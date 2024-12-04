using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Allen.Application.Services.Implements;

public class JwtTokenService : ITokenService
{
	private readonly string _secretKey;
	private readonly string _issuer;
	private readonly string _audience;

	public JwtTokenService(IConfiguration configuration)
	{
		_secretKey = configuration["JwtSettings:SecretKey"]!;
		_issuer = configuration["JwtSettings:Issuer"]!;
		_audience = configuration["JwtSettings:Audience"]!;
	}

	public string GenerateAccessToken(IEnumerable<Claim> claims)
	{
		var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey));
		var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

		var token = new JwtSecurityToken(
			issuer: _issuer,
			audience: _audience,
			claims: claims,
			expires: DateTime.UtcNow.AddMinutes(15),
			signingCredentials: creds);

		return new JwtSecurityTokenHandler().WriteToken(token);
	}

	public string GenerateRefreshToken()
	{
		return Guid.NewGuid().ToString();
	}

	public ClaimsPrincipal ValidateToken(string token)
	{
		var tokenHandler = new JwtSecurityTokenHandler();
		var key = Encoding.UTF8.GetBytes(_secretKey);

		try
		{
			var principal = tokenHandler.ValidateToken(token, new TokenValidationParameters
			{
				ValidateIssuer = true,
				ValidateAudience = true,
				ValidateLifetime = true,
				ValidateIssuerSigningKey = true,
				ValidIssuer = _issuer,
				ValidAudience = _audience,
				IssuerSigningKey = new SymmetricSecurityKey(key)
			}, out _);

			return principal;
		}
		catch
		{
			return null!;
		}
	}
}
