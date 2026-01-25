namespace CustomerApi.Domain
{
    public class Customer
    {
        public int Id { get; private set; }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string? PhoneNumber { get; private set; }
        public string? Address { get; private set; }

        

        public Customer(string firstName, string lastName, string? phoneNumber, string? address)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Address = address;
        }
    }
}
