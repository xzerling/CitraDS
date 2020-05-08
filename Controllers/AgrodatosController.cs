using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Xml;
using System.Globalization;
using CitraDataStore.Models;

namespace CitraDataStore.Controllers
{
    public class AgrodatosController : Controller
    {
        readonly SensoresContext context = new SensoresContext();

        

        public IActionResult Index()
        {
            
            List<Agrodatos> lista = context.GetStations();
            return View(lista);
        }


        [HttpGet]
        public JsonResult NombreSensores(int id)
        {
            //SensoresContext context = HttpContext.RequestServices.GetService(typeof(CitraDataStore.SensoresContext)) as SensoresContext;
            List<Agrodatos> lista = context.GetInstrumentos(id);
            return Json(lista);
        }

        [HttpPost]
        public IActionResult EnviarConsulta(int estacion, int datos, string fechaI, string fechaT, int separadorDatos,
            int separadorDecimales, int separadorMiles, int[] check)
        {
            //SensoresContext context = HttpContext.RequestServices.GetService(typeof(CitraDataStore.SensoresContext)) as SensoresContext;
            List<Report> resultado = context.SendDataRquest(estacion, datos, fechaI, fechaT, separadorDecimales, check);

            StringBuilder csv = new StringBuilder();

            if (separadorDatos == 1)
            {
                for (int i = 0; i < resultado.Count; i++)
                {
                    resultado.ElementAt(i).datos.Replace('.', ',');
                    csv.AppendLine(resultado.ElementAt(i).fecha.Replace(" 0:00:00", "") + ";" + resultado.ElementAt(i).hora + ";" + resultado.ElementAt(i).datos.Replace('|', ';'));
                }

            }
            else if (separadorDatos == 2)
            {
                for (int i = 0; i < resultado.Count; i++)
                {
                    string aux = resultado.ElementAt(i).datos.Replace('.', 'p');

                    csv.AppendLine(resultado.ElementAt(i).fecha.Replace(" 0:00:00", "") + "," + resultado.ElementAt(i).hora + "," + aux.Replace('|', ','));
                }
            }
            else if (separadorDatos == 3)
            {
                for (int i = 0; i < resultado.Count; i++)
                {
                    csv.AppendLine(resultado.ElementAt(i).fecha.Replace(" 0:00:00", "") + "\t" + resultado.ElementAt(i).hora + "\t" + resultado.ElementAt(i).datos.Replace('|', '\t'));
                }
            }


            return File(System.Text.Encoding.ASCII.GetBytes(csv.ToString()), "text/csv", "data.csv");
            //return resultado;
        }
    }
}