using System;
using System.Collections.Generic;

namespace CitraDataStore.Models
{
    public partial class Admins
    {
        public Admins()
        {
            EstacionesAsignadas = new HashSet<EstacionesAsignadas>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? RolesId { get; set; }
        public string IdEstacionesAsignadas { get; set; }
        public int Dias_disponibles { get; set; }

        public virtual Roles Roles { get; set; }
        public virtual ICollection<EstacionesAsignadas> EstacionesAsignadas { get; set; }
    }
}
