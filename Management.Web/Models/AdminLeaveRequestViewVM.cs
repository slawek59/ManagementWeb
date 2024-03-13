﻿using System.ComponentModel.DataAnnotations;

namespace Management.Web.Models
{
	public class AdminLeaveRequestViewVM
	{
		[Display(Name = "Total Number Of Requests")]
		public int TotalRequests { get; set; }

		[Display(Name = "Approved Requests")]
		public int ApprovedRequests { get; set; }

		[Display(Name = "Pending or Cancelled Requests")]
		public int PendingRequests { get; set; }

		[Display(Name = "Rejected Requests")]
		public int RejectedRequests { get; set; }

		public List<LeaveRequestVM> LeaveRequests { get; set; }
	}
}
