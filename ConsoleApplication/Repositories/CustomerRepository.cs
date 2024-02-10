using ConsoleApplication.Contexts;
using ConsoleApplication.Entities;

namespace ConsoleApplication.Repositories
{
    internal class CustomerRepository : Repo<CustomerEntity>
    {
        public CustomerRepository(DataContext context) : base(context)
        {
        }
    }
}
