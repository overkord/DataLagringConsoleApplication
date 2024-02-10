using ConsoleApplication.Contexts;
using ConsoleApplication.Entities;

namespace ConsoleApplication.Repositories
{
    internal class RoleRepository : Repo<RoleEntity>
    {
        public RoleRepository(DataContext context) : base(context)
        {
        }
    }
}
