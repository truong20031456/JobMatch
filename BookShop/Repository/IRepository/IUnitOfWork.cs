
namespace BookShop.Repository.IRepository
{
    public interface IUnitOfWork
    {
        public IApplicationRepository ApplicationRepository { get; }
        public IJobListingRepository JobListingRepository { get; }
        public IApplicationUsersRepository ApplicationUsers { get; }
        void Save();

    }
}
