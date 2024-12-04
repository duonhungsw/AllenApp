using System.Security.Cryptography;
using System.Text;

public static class PasswordHasher
{
	public static string HashPasswordPBKDF2(string password)
	{
		// Sử dụng salt cố định
		byte[] salt = Encoding.UTF8.GetBytes("MyFixedSaltValue"); // Salt cố định
		using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000, HashAlgorithmName.SHA256))
		{
			byte[] hash = pbkdf2.GetBytes(32); // Độ dài hash là 32 bytes
			return Convert.ToBase64String(hash);
		}
	}

	public static bool VerifyPasswordPBKDF2(string password, string storedHash)
	{
		// Sử dụng cùng salt cố định
		byte[] salt = Encoding.UTF8.GetBytes("MyFixedSaltValue");
		using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000, HashAlgorithmName.SHA256))
		{
			byte[] hash = pbkdf2.GetBytes(32);
			string computedHash = Convert.ToBase64String(hash);
			return computedHash == storedHash;
		}
	}
}
