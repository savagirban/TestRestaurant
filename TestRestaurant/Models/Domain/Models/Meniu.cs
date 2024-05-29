using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFis.Models.Domain.Models
{
    internal class Meniu
    {
        private string denumireMeniu;
        private string? descriereMeniu;
        List<CategorieMeniu> categorii;

        public Meniu(string denumireMeniu, string? descriereMeniu, List<CategorieMeniu> categorii)
        {
            this.denumireMeniu = denumireMeniu;
            this.descriereMeniu = descriereMeniu;
            this.categorii = categorii;
        }
    }
}
