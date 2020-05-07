using System;
using System.Collections.Generic;

namespace CitraDataStore.Models
{
    public partial class EstacionesAsignadas
    {
        public int Id { get; set; }
        public int Idusuario { get; set; }
        public int Idestacion { get; set; }

        public virtual Estacioneve IdestacionNavigation { get; set; }
        public virtual Admins IdusuarioNavigation { get; set; }
    }
}
