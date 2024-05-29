using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFis.Models.Domain.Models
{
    internal class CategorieMeniu
    {
        private string denumire;
        private List<Produs> produse;

        public CategorieMeniu(string denumire, List<Produs> produse)
        {
            this.denumire = denumire;
            this.produse = produse;
        }

        public string Denumire { get => denumire; set => denumire = value; }
        internal List<Produs> Produse { get => produse; set => produse = value; }
    }
}
