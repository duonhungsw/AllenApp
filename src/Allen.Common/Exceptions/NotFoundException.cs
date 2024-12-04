namespace Allen.Common.Exceptions;

public class NotFoundException : Exception
{
	public NotFoundException(string message) : base(message) { }
	public NotFoundException(string message, string detail) : base(message)
	{
		Details = detail;
	}
	public string? Details;
}
