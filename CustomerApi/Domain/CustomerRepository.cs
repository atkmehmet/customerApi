namespace CustomerApi.Domain
{
    interface  CustomerRepository
    {
        Task<List<Customer>> GetCustomersAsync();

        Task AddCostomer(Customer customer);
    }
}
