using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.Configuration;
using SacramentMeeting.Data;
using SacramentMeeting.Models;

namespace SacramentMeeting.Controllers
{
    public class MeetingsController : Controller
    {
        private readonly SacramentMeetingContext _context;

        public MeetingsController(SacramentMeetingContext context)
        {
            _context = context;
        }

        // GET: Meetings
        public async Task<IActionResult> Index(
    string searchString, 
    string sortOrder,
    string currentFilter,
    int? pageNumber)
        {
            {
                ViewData["CurrentSort"] = sortOrder;
                ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_asc" : "";
                ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";

                if (searchString != null)
                {
                    pageNumber = 1;
                }
                else
                {
                    searchString = currentFilter;
                }

                ViewData["CurrentFilter"] = searchString;

                var meetings = from s in _context.Meeting
                               select s;
                if (!String.IsNullOrEmpty(searchString))
                {
                    meetings = meetings.Where(s => s.President!.Contains(searchString) || s.Conductor.Contains(searchString)
                || s.MeetingDate.ToString().Contains(searchString) || s.OpeningHymn.Contains(searchString)
                || s.ClosingHymn.Contains(searchString));
                }
                switch (sortOrder)
                {
                    case "name_asc":
                        meetings = meetings.OrderBy(s => s.Conductor);
                        break;
                    case "Date":
                        meetings = meetings.OrderBy(s => s.MeetingDate);
                        break;
                    case "date_desc":
                        meetings = meetings.OrderByDescending(s => s.MeetingDate);
                        break;
                    default:
                        meetings = meetings.OrderByDescending(s => s.MeetingDate);
                        break;
                }

                int pageSize = 3;
                return View(await PaginatedList<Meeting>.CreateAsync(meetings.AsNoTracking(), pageNumber ?? 1, pageSize));
            }
        }

        // GET: Meetings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Meeting == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meeting
                .FirstOrDefaultAsync(m => m.Id == id);
            if (meeting == null)
            {
                return NotFound();
            }

            return View(meeting);
        }

        // GET: Meetings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Meetings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MeetingDate,President,Conductor,OpeningHymn,OpeningPrayer,SacramentHymn,IntermediateHymn,Speakers,SpeakerSubject,ClosingHymn,ClosingPrayer")] Meeting meeting)
        {
            if (ModelState.IsValid)
            {
                _context.Add(meeting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(meeting);
        }

        // GET: Meetings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Meeting == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meeting.FindAsync(id);
            if (meeting == null)
            {
                return NotFound();
            }
            return View(meeting);
        }

        // POST: Meetings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MeetingDate,President,Conductor,OpeningHymn,OpeningPrayer,SacramentHymn,IntermediateHymn,Speakers,SpeakerSubject,ClosingHymn,ClosingPrayer")] Meeting meeting)
        {
            if (id != meeting.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meeting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MeetingExists(meeting.Id))
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
            return View(meeting);
        }

        // GET: Meetings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Meeting == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meeting
                .FirstOrDefaultAsync(m => m.Id == id);
            if (meeting == null)
            {
                return NotFound();
            }

            return View(meeting);
        }

        // POST: Meetings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Meeting == null)
            {
                return Problem("Entity set 'SacramentMeetingContext.Meeting'  is null.");
            }
            var meeting = await _context.Meeting.FindAsync(id);
            if (meeting != null)
            {
                _context.Meeting.Remove(meeting);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MeetingExists(int id)
        {
          return _context.Meeting.Any(e => e.Id == id);
        }
    }
}
