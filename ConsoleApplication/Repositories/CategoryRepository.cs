using ConsoleApplication.Contexts;
using ConsoleApplication.Entities;

namespace ConsoleApplication.Repositories
{
    internal class CategoryRepository : Repo<CategoryEntity>
    {
        public CategoryRepository(DataContext context) : base(context)
        {
        }
    }
}
