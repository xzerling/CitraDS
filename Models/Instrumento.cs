using System;
using System.Collections.Generic;

namespace CitraDataStore.Models
{
    public partial class Instrumento
    {
        public int Id { get; set; }
        public string Unidad { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int? AdconId { get; set; }
        public string UbicacionNombre { get; set; }
        public string Observacion { get; set; }
        public DateTime? FechaInstalacion { get; set; }
        public int TipoInstrumentoId { get; set; }
        public int? EstacionId { get; set; }
        public int ResponsableId { get; set; }
        public int? RevisarDatos { get; set; }
    }
}
