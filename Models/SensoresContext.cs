using CitraDataStore.Models;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CitraDataStore
{
    public class SensoresContext:DbContext
    {
        public SensoresContext()
        {

        }

        public SensoresContext(DbContextOptions<SensoresContext> options)
            : base(options)
        {
        }

        private MySqlConnection GetDefaultConn()
        {
            return new MySqlConnection("Server=citrads.cmmqgr4kvqxz.us-east-2.rds.amazonaws.com;Database=citra;User=admin;Password=c1tr420cds");
        }


        public List<Agrodatos> GetAllStations() 
        {
            List<Agrodatos> lista = new List<Agrodatos>();

            using (MySqlConnection conn = GetDefaultConn())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT nombre, id FROM estacioneve", conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Agrodatos()
                        {
                            NombreEstacion = reader.GetString("nombre"),
                            Id = reader.GetInt32("id")

                        });
                    }
                }
                conn.Close();
            }


            return lista;
                
        }


        [AuthorizedAction]
        public List<Agrodatos> GetStations(int idUsuario)
        {
            List<Agrodatos> estaciones = new List<Agrodatos>();
            string est = "";
            string idEstacion = "SELECT nombre, id FROM estacioneve WHERE";
            try
            {
                using (MySqlConnection conn = GetDefaultConn())
                {
                    conn.Open();
                    if (idUsuario != 1)
                    {
                        MySqlCommand estacionesUsuarios = new MySqlCommand("SELECT id_estaciones_asignadas FROM admins WHERE admins.id = @id", conn);
                        estacionesUsuarios.Parameters.AddWithValue("@id", idUsuario);


                        using (MySqlDataReader reader = estacionesUsuarios.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                est = reader.GetString("id_estaciones_asignadas");
                            }

                            string q = " OR estacioneve.id = ";
                            idEstacion = idEstacion + est.Replace(",", q);
                            string Find = "OR";
                            int Place = idEstacion.IndexOf(Find);
                            idEstacion = idEstacion.Remove(Place, Find.Length).Insert(Place, "");

                        }


                        MySqlCommand cmd = new MySqlCommand(idEstacion, conn);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                estaciones.Add(new Agrodatos()
                                {
                                    NombreEstacion = reader.GetString("nombre"),
                                    Id = reader.GetInt32("id")

                                });
                            }
                        }
                    }

                    else
                    {
                        MySqlCommand cmd = new MySqlCommand("SELECT nombre, id FROM estacioneve", conn);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                estaciones.Add(new Agrodatos()
                                {
                                    NombreEstacion = reader.GetString("nombre"),
                                    Id = reader.GetInt32("id")

                                });
                            }
                        }
                    }


                    conn.Close();
                }
            }
            catch (Exception ex)
            {

            }
            return estaciones;
        }

        public List<Agrodatos> GetPiraStations()
        {
            List<Agrodatos> estaciones = new List<Agrodatos>();
            using (MySqlConnection conn = GetDefaultConn())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT estacioneve.nombre, instrumento.id FROM instrumento, estacioneve WHERE estacioneve.id = instrumento.estacion_id  AND instrumento.modelo = 'Pyranometer SP-Lite'", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        estaciones.Add(new Agrodatos()
                        {
                            NombreEstacion = reader.GetString("nombre"),
                            Id = reader.GetInt32("id")

                        });
                    }
                }
                conn.Close();
            }
            return estaciones;
        }

        public List<Agrodatos> GetInstrumentos(int id)
        {
            List<Agrodatos> Instrumentos = new List<Agrodatos>();
            using (MySqlConnection conn = GetDefaultConn())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT modelo, id, tipo_instrumento_id FROM instrumento WHERE estacion_id = @id ORDER BY tipo_instrumento_id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Instrumentos.Add(new Agrodatos()
                        {
                            NombreSensor = reader.GetString("modelo"),
                            Id = reader.GetInt32("tipo_instrumento_id")

                        });
                    }
                }
                conn.Close();
            }
            return Instrumentos;

        }

        //Consulta para obtener datos agronomicos de una estacion y fechas determinadas.

        public List<Report> SendDataRquest(int estacion, int datos, string fechaI, string fechaT, int separadorDecimales, int[] check)
        {
            int size = check.Length;

            string checkbox = "";
            for (int i = 0; i < size; i++)
            {
                checkbox += "AND tipo_instrumento_id !=" + check[i] + " ";
            }


            List<Report> reporte = new List<Report>();
            using (MySqlConnection conn = GetDefaultConn())
            {
                conn.Open();
                if (datos == 1)
                {
                    if (separadorDecimales == 1)
                    {
                        string consulta = "SELECT fecha, hora, GROUP_CONCAT(medicion.medicion order by tipo_instrumento_id SEPARATOR '|')AS medicion " +
                            "FROM `medicion`, `estacioneve`, `instrumento` WHERE estacioneve.id = instrumento.estacion_id AND estacioneve.id = @estacion" +
                            " AND medicion.instrumento_id = instrumento.id " + checkbox
                            + " AND fecha >= @fechaI AND fecha <= @fechaT group by fecha, hora";
                        MySqlCommand cmd = new MySqlCommand(consulta, conn);
                        cmd.Parameters.AddWithValue("@estacion", estacion);
                        cmd.Parameters.AddWithValue("@fechaI", fechaI);
                        cmd.Parameters.AddWithValue("@fechaT", fechaT);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("holamundo");
                                reporte.Add(new Report()
                                {
                                    fecha = reader.GetDateTime("fecha").Date.ToString("d"),
                                    hora = reader["hora"].ToString(),
                                    datos = reader.GetString("medicion")
                                });
                            }
                        }
                    }
                    if (separadorDecimales == 2)
                    {
                        string consulta = "SELECT fecha, hora, GROUP_CONCAT(FORMAT(medicion.medicion, 3, 'es_CL')order by tipo_instrumento_id SEPARATOR '|')AS medicion " +
                            "FROM `medicion`, `estacioneve`, `instrumento` WHERE estacioneve.id = instrumento.estacion_id AND estacioneve.id = @estacion" +
                            " AND medicion.instrumento_id = instrumento.id " + checkbox
                            + " AND fecha >= @fechaI AND fecha <= @fechaT group by fecha, hora";
                        MySqlCommand cmd = new MySqlCommand(consulta, conn);
                        cmd.Parameters.AddWithValue("@estacion", estacion);
                        cmd.Parameters.AddWithValue("@fechaI", fechaI);
                        cmd.Parameters.AddWithValue("@fechaT", fechaT);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("holamundo");
                                reporte.Add(new Report()
                                {
                                    fecha = reader.GetDateTime("fecha").Date.ToString("d"),

                                    hora = reader["hora"].ToString(),
                                    datos = reader.GetString("medicion")



                                });
                            }
                        }

                    }


                }
                if (datos == 2)
                {
                    if (separadorDecimales == 1)
                    {
                        string consulta = "SELECT fecha, hora, GROUP_CONCAT(medicion.medicion order by tipo_instrumento_id SEPARATOR '|')AS medicion" +
                            " FROM `medicion`, `estacioneve`, `instrumento` WHERE estacioneve.id = instrumento.estacion_id AND estacioneve.id = @estacion " +
                            "AND medicion.instrumento_id = instrumento.id " + checkbox +
                            " AND fecha >= @fechaI AND fecha <= @fechaT AND EXTRACT(MINUTE FROM hora)=0 group by fecha, hora";
                        MySqlCommand cmd = new MySqlCommand(consulta, conn);
                        cmd.Parameters.AddWithValue("@estacion", estacion);
                        cmd.Parameters.AddWithValue("@fechaI", fechaI);
                        cmd.Parameters.AddWithValue("@fechaT", fechaT);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("holamundo");
                                reporte.Add(new Report()
                                {
                                    fecha = reader.GetDateTime("fecha").Date.ToString("d"),
                                    hora = reader["hora"].ToString(),
                                    datos = reader.GetString("medicion")
                                });
                            }
                        }
                    }
                    if (separadorDecimales == 2)
                    {
                        string consulta = "SELECT fecha, hora, GROUP_CONCAT(FORMAT(medicion.medicion, 3, 'es_CL') order by tipo_instrumento_id SEPARATOR '|')AS medicion" +
                            " FROM `medicion`, `estacioneve`, `instrumento` WHERE estacioneve.id = instrumento.estacion_id AND estacioneve.id = @estacion " +
                            "AND medicion.instrumento_id = instrumento.id " + checkbox +
                            " AND fecha >= @fechaI AND fecha <= @fechaT AND EXTRACT(MINUTE FROM hora)=0 group by fecha, hora";
                        MySqlCommand cmd = new MySqlCommand(consulta, conn);
                        cmd.Parameters.AddWithValue("@estacion", estacion);
                        cmd.Parameters.AddWithValue("@fechaI", fechaI);
                        cmd.Parameters.AddWithValue("@fechaT", fechaT);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("holamundo");
                                reporte.Add(new Report()
                                {
                                    fecha = reader.GetDateTime("fecha").Date.ToString("d"),
                                    hora = reader["hora"].ToString(),
                                    datos = reader.GetString("medicion")
                                });
                            }
                        }
                    }

                }
                if (datos == 3)
                {
                    if (separadorDecimales == 1)
                    {
                        string consulta = "SELECT fecha, hora, GROUP_CONCAT(medicion.medicion order by tipo_instrumento_id SEPARATOR '|')AS medicion" +
                         " FROM `medicion`, `estacioneve`, `instrumento` WHERE estacioneve.id = instrumento.estacion_id AND estacioneve.id = @estacion " +
                         "AND medicion.instrumento_id = instrumento.id " + checkbox +
                         " AND fecha >= @fechaI AND fecha <= @fechaT AND EXTRACT(MINUTE FROM hora)=0 group by fecha, hora";
                        MySqlCommand cmd = new MySqlCommand(consulta, conn);
                        cmd.Parameters.AddWithValue("@estacion", estacion);
                        cmd.Parameters.AddWithValue("@fechaI", fechaI);
                        cmd.Parameters.AddWithValue("@fechaT", fechaT);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                reporte.Add(new Report()
                                {
                                    fecha = reader.GetDateTime("fecha").Date.ToString("d"),
                                    hora = reader["hora"].ToString(),
                                    datos = reader.GetString("medicion")
                                });
                            }
                        }
                    }
                    if (separadorDecimales == 2)
                    {
                        string consulta = "SELECT fecha, hora, GROUP_CONCAT(FORMAT(medicion.medicion, 3, 'es_CL') order by tipo_instrumento_id SEPARATOR '|')AS medicion" +
                            " FROM `medicion`, `estacioneve`, `instrumento` WHERE estacioneve.id = instrumento.estacion_id AND estacioneve.id = @estacion " +
                            "AND medicion.instrumento_id = instrumento.id " + checkbox +
                            " AND fecha >= @fechaI AND fecha <= @fechaT AND EXTRACT(MINUTE FROM hora)=0 group by fecha, hora";
                        MySqlCommand cmd = new MySqlCommand(consulta, conn);
                        cmd.Parameters.AddWithValue("@estacion", estacion);
                        cmd.Parameters.AddWithValue("@fechaI", fechaI);
                        cmd.Parameters.AddWithValue("@fechaT", fechaT);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("holamundo");
                                reporte.Add(new Report()
                                {
                                    fecha = reader.GetDateTime("fecha").Date.ToString("d"),
                                    hora = reader["hora"].ToString(),
                                    datos = reader.GetString("medicion")
                                });
                            }
                        }
                    }
                }


                conn.Close();


            }
            return reporte;
        }

        public List<Report> SendIndicatorRquest(int estacion, int datos, string fechaI, string fechaT, int separadorDecimales,  bool gd, bool hf, bool eto, bool eta)
        {
            List<Report> reporte = new List<Report>();
            string sepDec = "'en_US'";
            if(separadorDecimales == 2)
            {
                sepDec = "'es_CL'";
            }
            using (MySqlConnection conn = GetDefaultConn())
            {
                try
                {
                    conn.Open();
                    if (datos == 2)
                    {
                        string consulta = "SELECT T1.fecha, CONCAT_WS('|' ";

                        if (gd == true)
                        {
                            consulta = consulta + ", T1.gradosDia";
                        }
                        if (hf == true)
                        {
                            consulta = consulta + ", T1.horasFrio";
                        }
                        if (eto == true)
                        {
                            consulta = consulta + ", T2.ETo";
                        }
                        else
                        {
                            consulta = consulta + ", ''";
                        }

                        consulta += ") AS medicion ";

                        consulta = consulta + "FROM(SELECT gd_hf.fecha, FORMAT(gd_hf.gradosDia, 3, "+sepDec+") as gradosDia,FORMAT(gd_hf.horasFrio, 3, "+sepDec+") as horasFrio, gd_hf.id_estacion FROM gd_hf WHERE gd_hf.id_estacion = @estacion AND (gd_hf.fecha BETWEEN @fechaI AND @fechaT))AS T1," +
                            " (SELECT et_diario.fecha, et_diario.id_estacion, FORMAT(et_diario.ETo , 3, "+sepDec+") as ETo FROM et_diario WHERE et_diario.id_estacion = @estacion AND(et_diario.fecha BETWEEN @fechaI AND @fechaT))AS T2" +
                            " WHERE T1.fecha = T2.fecha";
                        MySqlCommand cmd = new MySqlCommand(consulta, conn);
                        cmd.Parameters.AddWithValue("@estacion", estacion);
                        cmd.Parameters.AddWithValue("@fechaI", fechaI);
                        cmd.Parameters.AddWithValue("@fechaT", fechaT);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //Console.WriteLine("holamundo");
                                reporte.Add(new Report()
                                {
                                    fecha = reader.GetDateTime("fecha").Date.ToString("d"),
                                    datos = reader.GetString("medicion")
                                }) ;
                            }
                        }

                    }
                    else if(datos == 1)
                    {
                        string consulta = "SELECT fecha, Hor, etia FROM `et_instantaneo` WHERE fecha BETWEEN @fechaI AND @fechaT AND estacion = @estacion";

                        MySqlCommand cmd = new MySqlCommand(consulta, conn);
                        cmd.Parameters.AddWithValue("@estacion", estacion);
                        cmd.Parameters.AddWithValue("@fechaI", fechaI);
                        cmd.Parameters.AddWithValue("@fechaT", fechaT);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //Console.WriteLine("holamundo");
                                reporte.Add(new Report()
                                {
                                    fecha = reader.GetDateTime("fecha").Date.ToString("d"),
                                    hora = reader.GetInt16("Hor").ToString(),
                                    datos = reader.GetDouble("etia").ToString()
                                });
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }

            return reporte;
        }

        public List<DatosGrafico> GetValorPiranometro(string estacion, string fechaI, string fechaT)
        {
            List<DatosGrafico> datos = new List<DatosGrafico>();
            using (MySqlConnection conn = GetDefaultConn())
            {
                conn.Open();
                string consulta = "SELECT fecha, medicion FROM `medicion` WHERE instrumento_id = @estacion And (fecha BETWEEN @fechaI AND @fechaT) AND hora = '12:00'";
                MySqlCommand cmd = new MySqlCommand(consulta, conn);
                cmd.Parameters.AddWithValue("@estacion", estacion);
                cmd.Parameters.AddWithValue("@fechaI", fechaI);
                cmd.Parameters.AddWithValue("@fechaT", fechaT);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        datos.Add(new DatosGrafico()
                        {
                            fecha = reader.GetDateTime("fecha").Date.ToString("d"),
                            valor = (double)reader["medicion"]
                        });
                    }
                }
                conn.Close();
            }
            return datos;

        }

    }
}
