using ConsoleApplication.Contexts;
using ConsoleApplication.Entities;

namespace ConsoleApplication.Repositories
{
    internal class ProductRepository : Repo<ProductEntity>
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }
    }
}
