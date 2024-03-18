using Management.Application.Contracts;
using Management.Data;

namespace Management.Application.Repositories
{
	public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
	{
		public LeaveTypeRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}
