using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitraDataStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CitraDataStore.Controllers
{
    public class EstacionesAsignadasController : Controller
    {
        MyDbContext _context = new MyDbContext();


        // GET: Admins
        [AuthorizedAction]
        public async Task<IActionResult> Index()
        {
            
            return View(await _context.Estacioneve.ToListAsync());
        }

        // GET: Admins/Create
        [AuthorizedAction]
        public IActionResult Create()
        {
            ViewBag.RolesId = new SelectList(_context.Roles, "Id", "Title");
            return View();
        }

        // POST: Admins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("id,idusuario,idestacion")] EstacionesAsignadas estacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estacion);
        }

        // GET: Admins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admins = await _context.Admins.SingleOrDefaultAsync(m => m.Id == id);
            if (admins == null)
            {
                return NotFound();
            }
            ViewData["RolesId"] = new SelectList(_context.Roles, "Id", "Title", admins.RolesId);
            return View(admins);
        }

        // POST: Admins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,Email,RolesId")] Admins admins)
        {
            if (id != admins.Id)
            {
                return NotFound();
            }

            Admins admin = await _context.Admins.Where(s => s.Id == admins.Id).FirstOrDefaultAsync();
            admin.FullName = admins.FullName;
            admin.Email = admins.Email;
            admin.RolesId = admins.RolesId;
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // GET: Admins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admins = await _context.Admins
                .Include(a => a.Roles)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (admins == null)
            {
                return NotFound();
            }

            return View(admins);
        }

        // POST: Admins/DeleteConfirmed/5
        [HttpPost, ActionName("DeleteConfirmed")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var admins = await _context.Admins.SingleOrDefaultAsync(m => m.Id == id);
            _context.Admins.Remove(admins);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdminsExists(int id)
        {
            return _context.Admins.Any(e => e.Id == id);
        }
    }
}
