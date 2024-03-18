using Management.Data;
using Management.Common.Models;

namespace Management.Application.Contracts
{
	public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
	{
		Task LeaveAllocation(int leaveTypeId);
		Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);
		Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);
		Task<LeaveAllocation?> GetEmployeeAllocation(string employeeId, int leaveTypeID);
		Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id);
		Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model);
	}
}
