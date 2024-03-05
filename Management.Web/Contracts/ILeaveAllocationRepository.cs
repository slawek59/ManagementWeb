using Management.Web.Data;
using Management.Web.Models;

namespace Management.Web.Contracts
{
	public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
	{
		Task LeaveAllocation(int leaveTypeId);
		Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);
		Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);
		Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id);
		Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model);
	}
}
