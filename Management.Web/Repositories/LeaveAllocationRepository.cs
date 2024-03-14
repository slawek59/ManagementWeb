﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using Management.Web.Constants;
using Management.Web.Contracts;
using Management.Web.Data;
using Management.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Management.Web.Repositories
{
	public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
	{
		private readonly ApplicationDbContext _context;
		private readonly UserManager<Employee> _userManager;
		private readonly ILeaveTypeRepository _leaveTypeRepository;
		private readonly AutoMapper.IConfigurationProvider _configurationProvider;
		private readonly IMapper _mapper;

		public LeaveAllocationRepository(ApplicationDbContext context,
			UserManager<Employee> userManager,
			ILeaveTypeRepository leaveTypeRepository,
			AutoMapper.IConfigurationProvider configurationProvider,
			IMapper mapper) : base(context)
		{
			_context = context;
			_userManager = userManager;
			_leaveTypeRepository = leaveTypeRepository;
			_configurationProvider = configurationProvider;
			_mapper = mapper;
		}

		public async Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period)
		{
			return await _context.LeaveAllocations.AnyAsync(q => q.EmployeeId == employeeId
															&& q.LeaveTypeId == leaveTypeId
															&& q.Period == period
															);
		}

		public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId)
		{
			var allocations = await _context.LeaveAllocations
				.Include(q => q.LeaveType)
				.Where(q => q.EmployeeId == employeeId)
				.ProjectTo<LeaveAllocationVM>(_configurationProvider)
				.ToListAsync();

			var employees = await _userManager.FindByIdAsync(employeeId);

			var employeeAllocationModel = _mapper.Map<EmployeeAllocationVM>(employees);
			employeeAllocationModel.LeaveAllocations = _mapper.Map<List<LeaveAllocationVM>>(allocations);

			return employeeAllocationModel;
		}

		public async Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id)
		{
			var allocation = await _context.LeaveAllocations
				.Include(q => q.LeaveType)
				.FirstOrDefaultAsync(q => q.Id == id);

			if (allocation == null)
			{
				return null;
			}

			var employee = await _userManager.FindByIdAsync(allocation.EmployeeId);

			var model = _mapper.Map<LeaveAllocationEditVM>(allocation);
			model.Employee = _mapper.Map<EmployeeListVM>(await _userManager.FindByIdAsync(allocation.EmployeeId));

			return model;
		}

		public async Task LeaveAllocation(int leaveTypeId)
		{
			var employees = await _userManager.GetUsersInRoleAsync(Roles.User);
			var period = DateTime.Now.Year;
			var leaveType = await _leaveTypeRepository.GetAsync(leaveTypeId);
			var allocations = new List<LeaveAllocation>();

			foreach (var employee in employees)
			{
				if (await AllocationExists(employee.Id, leaveTypeId, period))
					continue;
				allocations.Add(new LeaveAllocation
				{
					EmployeeId = employee.Id,
					LeaveTypeId = leaveTypeId,
					Period = period,
					NumberOfDays = leaveType.DefaultDays
				});
			}

			await AddRangeAsync(allocations);
		}

		public async Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model)
		{
			var leaveAllocation = await GetAsync(model.Id);
			if (leaveAllocation == null)
			{
				return false;
			}
			leaveAllocation.Period = model.Period;
			leaveAllocation.NumberOfDays = model.NumberOfDays;
			await UpdateAsync(leaveAllocation);

			return true;
		}
		public async Task<LeaveAllocation?> GetEmployeeAllocation(string employeeId, int leaveTypeId)
		{
			return await _context.LeaveAllocations.FirstOrDefaultAsync(q => q.EmployeeId == employeeId && q.LeaveTypeId == leaveTypeId);
		}
	}
}
