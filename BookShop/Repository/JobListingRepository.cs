using BookShop.Data;
using BookShop.Models;
using BookShop.Repository.IRepository;

namespace BookShop.Repository
{
	public class JobListingRepository : Repository<JobListingModel>, IJobListingRepository
	{
		private readonly ApplicationDbContext _context;
		public JobListingRepository(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}

		public void Update(JobListingModel jobListing)
		{
			_context.JobListingModels.Update(jobListing);
		}
	}
}
