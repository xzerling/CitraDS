using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CitraDataStore.Models;
using Microsoft.AspNetCore.Http;

namespace CitraDataStore.Controllers
{
    public class HomeController : Controller
    {
        MyDbContext db = new MyDbContext();
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("email") == null)
            {
                return Redirect("/Account/Login");
            }

            DashboardViewModel dashboard = new DashboardViewModel();

            dashboard.admins_count = db.Admins.Count();
            dashboard.estaciones_count = db.Estacioneve.Count();
            dashboard.Indicadores_count = 3;
            dashboard.Mediciones_count = db.Medicion.Count();
            return View(dashboard);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
