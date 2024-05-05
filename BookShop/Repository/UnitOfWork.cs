using BookShop.Data;
using BookShop.Repository.IRepository;

namespace BookShop.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IApplicationRepository ApplicationRepository { get; private set; }
        public IJobListingRepository JobListingRepository { get; private set; }
        public IApplicationUsersRepository ApplicationUsers { get; private set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            
            ApplicationRepository = new ApplicationRepository(context);
            JobListingRepository = new JobListingRepository(context);
            ApplicationUsers = new ApplicationUserRepository(context);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
