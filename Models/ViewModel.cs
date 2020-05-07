using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitraDataStore.Models
{
    public class ViewModel
    {

        public IEnumerable<Admins> Admins { get; set; }
        public IEnumerable<Estacioneve> Agrodatos { get; set; }
    }
}
