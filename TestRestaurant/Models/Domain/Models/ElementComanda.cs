using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFis.Models.Domain.Models
{
    public class ElementComanda
    {
        private Produs produs;
        private int cantitate;

        public ElementComanda(Produs produs, int cantitate)
        {
            this.produs = produs;
            this.cantitate = cantitate;
        }

        public int Cantitate { get => cantitate; set => cantitate = value; }
        internal Produs Produs { get => produs; set => produs = value; }
    }
}
