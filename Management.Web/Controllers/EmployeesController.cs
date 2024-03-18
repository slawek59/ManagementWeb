﻿using AutoMapper;
using Management.Common.Constants;
using Management.Application.Contracts;
using Management.Data;
using Management.Application.Repositories;
using Management.Common.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Management.Web.Controllers
{
	public class EmployeesController : Controller
	{
		private readonly UserManager<Employee> _userManager;
		private readonly IMapper _mapper;
		private readonly ILeaveAllocationRepository _leaveAllocationRepository;
		private readonly ILeaveTypeRepository _leaveTypeRepository;

		public EmployeesController(UserManager<Employee> userManager, IMapper mapper, ILeaveAllocationRepository leaveAllocationRepository, ILeaveTypeRepository leaveTypeRepository)
		{
			_userManager = userManager;
			_mapper = mapper;
			_leaveAllocationRepository = leaveAllocationRepository;
			_leaveTypeRepository = leaveTypeRepository;
		}

		// GET: EmployeesControler
		public async Task<IActionResult> Index()
		{
			var employees = await _userManager.GetUsersInRoleAsync(Roles.User);
			var model = _mapper.Map<List<EmployeeListVM>>(employees);
			return View(model);
		}

		// GET: EmployeesControler/ViewAllocations/employeeId
		public async Task<IActionResult> ViewAllocations(string id)
		{
			var model = await _leaveAllocationRepository.GetEmployeeAllocations(id);
			return View(model);
		}

		// GET: EmployeesControler/EditAllocation/5
		public async Task<IActionResult> EditAllocation(int id)
		{
			var model = await _leaveAllocationRepository.GetEmployeeAllocation(id);
			if (model == null)
			{
				return NotFound();
			}

			return View(model);
		}

		// POST: EmployeesControler/EditAllocation/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> EditAllocation(int id, LeaveAllocationEditVM model)
		{
			try
			{
				if (ModelState.IsValid)
				{
					if (await _leaveAllocationRepository.UpdateEmployeeAllocation(model))
					{
						return RedirectToAction(nameof(ViewAllocations), new { id = model.EmployeeId });
					}

				}
			}
			catch (Exception ex)
			{
				ModelState.AddModelError(string.Empty, "An Error Has Occured. Please Try Again Later.");
			}
			model.Employee = _mapper.Map<EmployeeListVM>(await _userManager.FindByIdAsync(model.EmployeeId));
			model.LeaveType = _mapper.Map<LeaveTypeVM>(await _leaveTypeRepository.GetAsync(model.LeaveTypeId));

			return View(model);
		}
	}
}
