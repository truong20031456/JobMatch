using BookShop.Data;
using BookShop.Models;
using BookShop.Repository.IRepository;

namespace BookShop.Repository
{
	public class ApplicationRepository:Repository<ApplicationModel>, IApplicationRepository
    {
		private readonly ApplicationDbContext _context;
		public ApplicationRepository(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}

		public void Update(ApplicationModel Application)
		{
			_context.ApplicationModels.Update(Application);
		}
	}
}
