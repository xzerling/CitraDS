using System;
using System.Collections.Generic;

namespace CitraDataStore.Models
{
    public partial class Medicion
    {
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public double Medicion1 { get; set; }
        public int InstrumentoId { get; set; }
        public int Estado { get; set; }
    }
}
