using System;
using System.Collections.Generic;

namespace CitraDataStore.Models
{
    public partial class Estacioneve
    {
        public Estacioneve()
        {
            EstacionesAsignadas = new HashSet<EstacionesAsignadas>();
        }

        public int Id { get; set; }
        public int AdconId { get; set; }
        public string Nombre { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public double? Altura { get; set; }
        public int? IntentosDeDescarga { get; set; }
        public int? EstacionClonId { get; set; }
        public string Estado { get; set; }
        public int? Descargar { get; set; }
        public int? Clonar { get; set; }
        public int? FuenteDeDatosId { get; set; }
        public int? Rtu { get; set; }

        public virtual ICollection<EstacionesAsignadas> EstacionesAsignadas { get; set; }
    }
}
