using BookShop.Models;

namespace BookShop.Repository.IRepository
{
	public interface IJobListingRepository : IRepository<JobListingModel>
	{
		void Update(JobListingModel Job);
	}
}
