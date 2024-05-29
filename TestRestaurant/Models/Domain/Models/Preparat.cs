using RestaurantFis.Models.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFis.Models.Domain.Models
{
    public class Preparat : Produs
    {
        private readonly List<Ingredient> ingrediente;

        public Preparat()
        {
            ingrediente = new List<Ingredient>();
        }

        public Preparat(string denumire, string descriere, double pret, StatusProdus statusProdus, DimensiuneProdus dimensiuneProdus) : base(denumire, descriere, pret, statusProdus, dimensiuneProdus)
        {
            ingrediente = new List<Ingredient>();
        }
        public Preparat(List<Ingredient> ingrediente, string denumire, string descriere, double pret, StatusProdus statusProdus, DimensiuneProdus dimensiuneProdus) : base(denumire, descriere, pret, statusProdus, dimensiuneProdus)
        {
            this.ingrediente = ingrediente;
        }
        public Preparat(List<Ingredient> ingrediente, string denumire, string descriere, double pret ) : base(denumire, descriere, pret)
        {
            this.ingrediente = ingrediente;
        }
        public List<Ingredient> Ingrediente => ingrediente;
    }

}
