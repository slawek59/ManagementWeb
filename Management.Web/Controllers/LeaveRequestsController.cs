﻿using Management.Common.Constants;
using Management.Application.Contracts;
using Management.Data;
using Management.Common.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Management.Web.Controllers
{
	[Authorize]
	public class LeaveRequestsController : Controller
	{
		private readonly ApplicationDbContext _context;
		private readonly ILeaveRequestRepository _leaveRequestRepository;
		private readonly ILogger<LeaveRequestsController> _logger;

		public LeaveRequestsController(ApplicationDbContext context, ILeaveRequestRepository leaveRepository, ILogger<LeaveRequestsController> logger)
		{
			_context = context;
			_leaveRequestRepository = leaveRepository;
			_logger = logger;
		}

		[Authorize(Roles = Roles.Administrator)]
		// GET: LeaveRequests
		public async Task<IActionResult> Index()
		{
			var model = await _leaveRequestRepository.GetAdminLeaveRequestList();
			return View(model);
		}

		public async Task<ActionResult> MyLeave()
		{
			var model = await _leaveRequestRepository.GetMyLeaveDetails();
			return View(model);
		}

		// GET: LeaveRequests/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			var model = await _leaveRequestRepository.GetLeaveRequestAsync(id);

			if (model == null)
			{
				return NotFound();
			}

			return View(model);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> ApproveRequest(int id, bool approved)
		{
			try
			{
				await _leaveRequestRepository.ChangeAprovalStatus(id, approved);
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "Error Approving Leave Request");
				throw;
			}

			return RedirectToAction(nameof(Index));
		}

		// GET: LeaveRequests/Create
		public IActionResult Create()
		{
			var model = new LeaveRequestCreateVM
			{
				LeaveTypes = new SelectList(_context.LeaveTypes, "Id", "Name"),
			};
			return View(model);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Cancel(int id)
		{
			try
			{
				await _leaveRequestRepository.CancelLeaveRequest(id);
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "Error Cancelling Leave Request");
				throw;
			}
			return RedirectToAction(nameof(MyLeave));
		}

		// POST: LeaveRequests/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(LeaveRequestCreateVM model)
		{
			try
			{
				var isValidRequest = await _leaveRequestRepository.CreateLeaveRequest(model);

				if (isValidRequest)
				{
					return RedirectToAction(nameof(MyLeave));
				}
				ModelState.AddModelError(string.Empty, "You have exceeded your allocation with this request.");
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "Error Creating Leave Request");
				ModelState.AddModelError(string.Empty, "An Error Has Occured. Please Try Again Later.");
			}
			model.LeaveTypes = new SelectList(_context.LeaveTypes, "Id", "Name", model.LeaveTypeId);
			return View(model);
		}

		// GET: LeaveRequests/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null || _context.LeaveRequests == null)
			{
				return NotFound();
			}

			var leaveRequest = await _context.LeaveRequests.FindAsync(id);
			if (leaveRequest == null)
			{
				return NotFound();
			}
			ViewData["LeaveTypeId"] = new SelectList(_context.LeaveTypes, "Id", "Id", leaveRequest.LeaveTypeId);
			return View(leaveRequest);
		}

		// POST: LeaveRequests/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("StartDate,EndDate,LeaveTypeId,DateRequested,RequestComments,Approved,Cancelled,RequestingEmployeeId,Id,DateCreated,DateModified")] LeaveRequest leaveRequest)
		{
			if (id != leaveRequest.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(leaveRequest);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!LeaveRequestExists(leaveRequest.Id))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			ViewData["LeaveTypeId"] = new SelectList(_context.LeaveTypes, "Id", "Id", leaveRequest.LeaveTypeId);
			return View(leaveRequest);
		}

		// GET: LeaveRequests/Delete/5
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null || _context.LeaveRequests == null)
			{
				return NotFound();
			}

			var leaveRequest = await _context.LeaveRequests
				.Include(l => l.LeaveType)
				.FirstOrDefaultAsync(m => m.Id == id);
			if (leaveRequest == null)
			{
				return NotFound();
			}

			return View(leaveRequest);
		}

		// POST: LeaveRequests/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			if (_context.LeaveRequests == null)
			{
				return Problem("Entity set 'ApplicationDbContext.LeaveRequests'  is null.");
			}
			var leaveRequest = await _context.LeaveRequests.FindAsync(id);
			if (leaveRequest != null)
			{
				_context.LeaveRequests.Remove(leaveRequest);
			}

			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool LeaveRequestExists(int id)
		{
			return (_context.LeaveRequests?.Any(e => e.Id == id)).GetValueOrDefault();
		}
	}
}
