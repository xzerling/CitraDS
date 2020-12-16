using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Xml;
using System.Globalization;
using CitraDataStore.Models;
using Microsoft.AspNetCore.Http;

namespace CitraDataStore.Controllers
{
    public class AgrodatosController : Controller
    {
        readonly SensoresContext context = new SensoresContext();


        
        public IActionResult Index()
        {

            List<Agrodatos> lista = context.GetPiraStations();
            return View(lista);
        }

        [AuthorizedAction]
        public IActionResult Datos()
        {
            int id = HttpContext.Session.GetInt32("id").GetValueOrDefault();
            List<Agrodatos> lista = context.GetStations(id);
            return View(lista);
        }

        public JsonResult ValorPiranometro(string estacion, string fechaI, string fechaT)
        {
            List<DatosGrafico> resultado = context.GetValorPiranometro(estacion, fechaI, fechaT);
            return Json(resultado);
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

            char separador = ';';
            if (separadorDatos == 1)
            {
                separador = ';';
            }
            else if (separadorDatos == 2)
            {
                separador = ',';
            }
            else if (separadorDatos == 3)
            {
                separador = '\t';
            }



            if (separadorDatos == 1)
            {
                for (int i = 0; i < resultado.Count; i++)
                {
                    resultado.ElementAt(i).datos.Replace('.', ',');
                    csv.AppendLine(resultado.ElementAt(i).fecha + ";" + resultado.ElementAt(i).hora + ";" + resultado.ElementAt(i).datos.Replace('|', ';'));
                }

            }
            else if (separadorDatos == 2)
            {
                for (int i = 0; i < resultado.Count; i++)
                {
                    string aux = resultado.ElementAt(i).datos.Replace('.', ',');

                    csv.AppendLine(resultado.ElementAt(i).fecha + "," + resultado.ElementAt(i).hora + "," + aux.Replace('|', ','));
                }
            }
            else if (separadorDatos == 3)
            {
                for (int i = 0; i < resultado.Count; i++)
                {
                    csv.AppendLine(resultado.ElementAt(i).fecha + "\t" + resultado.ElementAt(i).hora + "\t" + resultado.ElementAt(i).datos.Replace('|', '\t'));
                }
            }


            return File(System.Text.Encoding.ASCII.GetBytes(csv.ToString()), "text/csv", "data.csv");
            //return resultado;
        }

        [HttpPost]
        public IActionResult EnviarConsultaIndicadores(int estacion, int datos, string fechaI, string fechaT, int separadorDatos, bool gd, bool hf, bool eto, bool eta,
        int separadorDecimales, int separadorMiles, int[] check)
        {
            //SensoresContext context = HttpContext.RequestServices.GetService(typeof(CitraDataStore.SensoresContext)) as SensoresContext;
            List<Report> resultado = context.SendIndicatorRquest(estacion, datos, fechaI, fechaT, separadorDecimales, gd, hf, eto, eta);

            StringBuilder csv = new StringBuilder();

            char separador = ';';
            if(separadorDatos == 1)
            {
                separador = ';';
            }
            else if(separadorDatos == 2)
            {
                separador = ',';
            }
            else if(separadorDatos == 3)
            {
                separador = '\t';
            }

            if(datos==2)
            {
                for (int i = 0; i < resultado.Count; i++)
                {
                    csv.AppendLine(resultado.ElementAt(i).fecha+ separador + resultado.ElementAt(i).datos.Replace('|', separador));
                }
            }
            else if(datos == 1)
            {
                for (int i = 0; i < resultado.Count; i++)
                {
                    csv.AppendLine(resultado.ElementAt(i).fecha+ separador + resultado.ElementAt(i).hora+":00:00" +separador+ resultado.ElementAt(i).datos);
                }
            }



            return File(System.Text.Encoding.ASCII.GetBytes(csv.ToString()), "text/csv", "data.csv");
            //return resultado;
        }


        //Post bien hecho
        [HttpPost]
        public bool EnviarDatosPoligono([FromBody] Poligonos pol)
        {
            //Console.WriteLine(poly);
            //Console.WriteLine(nombre);
            //Console.WriteLine(idUsuario);
            int aux = pol.IdAdmin;
            //int aux2 = pol.IdPoligonos;
            string aux3 = pol.Nombre;
            string aux4 = pol.Coordenadas;
            return context.Guardarpoligono(aux, aux4, aux3);
        }

        [HttpGet]
        public JsonResult CargarDatosPoligono()
        {
            int id = HttpContext.Session.GetInt32("id").GetValueOrDefault();
            return Json(context.CargarPoligono(id));
        }



    }
}