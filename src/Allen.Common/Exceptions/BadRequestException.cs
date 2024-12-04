namespace Allen.Common.Exceptions;

public class BadRequestException : Exception
{
	public BadRequestException(string message) : base(message) { }
	public BadRequestException(string message, string detail) : base(message)
	{
		Details = detail;
	}
	public string? Details;
}
