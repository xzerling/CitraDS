using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace CitraDataStore.Models
{
    public class Agrodatos
    {

        

        public string NombreEstacion { get; set; }
        public int Id { get; set; }
        public string NombreSensor { get; set; }


    }


}
