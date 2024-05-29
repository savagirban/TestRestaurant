using RestaurantFis.Models.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFis.Models.Domain.Models
{
    public class Personal
    {
        private RolAngajat rol;

        public Personal(RolAngajat rol)
        {
            this.rol = rol;
        }

        internal RolAngajat Rol { get { return rol; } set { rol = value; } }
    }
}
