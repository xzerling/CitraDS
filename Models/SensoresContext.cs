using CitraDataStore.Models;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
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



        public List<Agrodatos> GetStations()
        {
            List<Agrodatos> estaciones = new List<Agrodatos>();
            using (MySqlConnection conn = GetDefaultConn())
            {
                conn.Open();
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
                                    fecha = reader["fecha"].ToString(),
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
                                    fecha = reader["fecha"].ToString(),

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
                                    fecha = reader["fecha"].ToString(),
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
                                    fecha = reader["fecha"].ToString(),
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
                                    fecha = reader["fecha"].ToString(),
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
                                    fecha = reader["fecha"].ToString(),
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

    }
}
