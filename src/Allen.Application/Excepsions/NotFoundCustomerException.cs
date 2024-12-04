namespace Allen.API.Exceptions
{
	public class NotFoundCustomerException : Exception
	{
        public NotFoundCustomerException(object name) :base ($"Not found customer with name: {name}")
        {
            
        }
    }
}
