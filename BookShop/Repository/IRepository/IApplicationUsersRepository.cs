using BookShop.Models;

namespace BookShop.Repository.IRepository
{
    public interface IApplicationUsersRepository : IRepository<ApplicationUser>
    {
        void Update(ApplicationUser user);
    }
}
