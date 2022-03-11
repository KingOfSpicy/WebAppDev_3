using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CheWei_Task7Practice2.Data;
using CheWei_Task7Practice2.Models;

namespace CheWei_Task7Practice2.Controllers
{
    public class TypeOfRoomsController : Controller
    {
        private readonly CheWei_Task7Practice2Context _context;

        public TypeOfRoomsController(CheWei_Task7Practice2Context context)
        {
            _context = context;
        }

        // GET: TypeOfRooms
        public async Task<IActionResult> Index()
        {
            return View(await _context.TypeOfRoom.ToListAsync());
        }

        // GET: TypeOfRooms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeOfRoom = await _context.TypeOfRoom
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typeOfRoom == null)
            {
                return NotFound();
            }

            return View(typeOfRoom);
        }

        // GET: TypeOfRooms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TypeOfRooms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] TypeOfRoom typeOfRoom)
        {
            if (ModelState.IsValid)
            {
                _context.Add(typeOfRoom);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(typeOfRoom);
        }

        // GET: TypeOfRooms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeOfRoom = await _context.TypeOfRoom.FindAsync(id);
            if (typeOfRoom == null)
            {
                return NotFound();
            }
            return View(typeOfRoom);
        }

        // POST: TypeOfRooms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] TypeOfRoom typeOfRoom)
        {
            if (id != typeOfRoom.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(typeOfRoom);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypeOfRoomExists(typeOfRoom.Id))
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
            return View(typeOfRoom);
        }

        // GET: TypeOfRooms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeOfRoom = await _context.TypeOfRoom
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typeOfRoom == null)
            {
                return NotFound();
            }

            return View(typeOfRoom);
        }

        // POST: TypeOfRooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var typeOfRoom = await _context.TypeOfRoom.FindAsync(id);
            _context.TypeOfRoom.Remove(typeOfRoom);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypeOfRoomExists(int id)
        {
            return _context.TypeOfRoom.Any(e => e.Id == id);
        }
    }
}
