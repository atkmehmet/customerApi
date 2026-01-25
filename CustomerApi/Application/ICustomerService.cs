namespace CustomerApi.Application
{
    public interface ICustomerService
    {
        Task GetCustomer();
        Task AddCustomer(CustomerDto dto);
    }
}
