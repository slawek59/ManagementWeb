using Management.Web.Contracts;
using Management.Web.Data;

namespace Management.Web.Repositories
{
	public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
	{
		public LeaveTypeRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}
