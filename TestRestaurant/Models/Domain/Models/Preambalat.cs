using RestaurantFis.Models.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFis.Models.Domain.Models
{
    internal class Preambalat : Produs
    {
        private DateTime dataExpirare;

       
        public Preambalat() : base() { }

        public Preambalat(string denumire, string descriere, double pret) : base(denumire, descriere, pret)
        {
        }
        
        public Preambalat(string denumire, string descriere, double pret, DateTime expirare) : base(denumire, descriere, pret)
        {
            this.dataExpirare = expirare;
        }

        public Preambalat(string denumire, string descriere, double pret, StatusProdus statusProdus, DimensiuneProdus dimensiuneProdus) : base(denumire, descriere, pret, statusProdus, dimensiuneProdus)
        {
        }

        public DateTime DataExpirare { get => dataExpirare; set => dataExpirare = value; }
    }
}
