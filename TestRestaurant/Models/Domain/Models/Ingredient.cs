using RestaurantFis.Models.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFis.Models.Domain.Models
{
    public class Ingredient
    {
        private string denumire;
        private StilAlimentar stilAlimentar;

        public Ingredient(string denumire, StilAlimentar stilAlimentar)
        {
            this.denumire = denumire;
            this.stilAlimentar = stilAlimentar;
        }

        public string Denumire { get => denumire; set => denumire = value; }

        public override bool Equals(object? obj)
        {
            return obj is Ingredient ingredient &&
                   denumire == ingredient.denumire;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(denumire);
        }
    }
}
