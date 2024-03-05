using System.Reflection.Metadata.Ecma335;

namespace Management.Web.Models
{
	public class LeaveAllocationEditVM : LeaveAllocationVM
	{
        public string EmployeeId { get; set; }
        public int LeaveTypeId { get; set; }
        public EmployeeListVM? Employee { get; set; }
    }
}
