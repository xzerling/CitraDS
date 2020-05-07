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
    public class ViewModelController : Controller
    {
        MyDbContext _context = new MyDbContext();

        public IActionResult Index()
        {
            ViewModel mymodel = new ViewModel();
            var usuarios = _context.Admins.Include(a => a.Roles);
            var estaciones = _context.Estacioneve;
            mymodel.Admins = usuarios;
            mymodel.Agrodatos = estaciones;

            return View(mymodel);
        }
    }
}