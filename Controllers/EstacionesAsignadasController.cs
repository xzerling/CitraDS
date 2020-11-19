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
        readonly SensoresContext context = new SensoresContext();


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
        public async Task<IActionResult> Create([Bind("Id,AdconId,Nombre,Latitud, Longitud")] Estacioneve estacion)
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

            var estacioneve = await _context.Estacioneve.SingleOrDefaultAsync(m => m.Id == id);
            if (estacioneve == null)
            {
                return NotFound();
            }
            //ViewData["RolesId"] = new SelectList(_context.Roles, "Id", "Title", admins.RolesId);
            return View(estacioneve);
        }

        // POST: Admins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AdconId,Nombre,Latitud, Longitud")] Estacioneve estaciones)
        {
            if (id != estaciones.Id)
            {
                return NotFound();
            }

            Estacioneve estacion = await _context.Estacioneve.Where(s => s.Id == estaciones.Id).FirstOrDefaultAsync();
            estacion.Id = estaciones.Id;
            estacion.AdconId = estaciones.AdconId;
            estacion.Nombre = estaciones.Nombre;
            estacion.Latitud = estaciones.Latitud;
            estacion.Longitud = estaciones.Longitud;
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
            var estacion = await _context.Estacioneve.SingleOrDefaultAsync(m => m.Id == id);
            _context.Estacioneve.Remove(estacion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdminsExists(int id)
        {
            return _context.Admins.Any(e => e.Id == id);
        }

        
        [HttpGet]
        public JsonResult NombreEstaciones()
        {
            List<Agrodatos> lista = context.GetAllStations();
            return Json(lista);
        }
    }
}
