using BookShop.Models;

namespace BookShop.Repository.IRepository
{
	public interface IApplicationRepository:IRepository<ApplicationModel>
	{
		void Update(ApplicationModel Application);
	}
}
