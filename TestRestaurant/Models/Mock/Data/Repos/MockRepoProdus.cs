using RestaurantFis.Models.Domain.Interfaces;
using RestaurantFis.Models.Domain.Models;
using RestaurantFis.Models.Domain.Models.Enums;

namespace RestaurantFis.Models.Mock.Data.Repos
{
    public class MockRepoProdus : IRepoProdus
    {
        List<Produs> produse = new()
        {
            new Preparat(new(){ new("linte",StilAlimentar.VEGAN),new("rosii",0),new("piper",0)},"supa crema","supa crema nempicanta de linte",56.9,Domain.Models.Enums.StatusProdus.DISPONIBIL,DimensiuneProdus.LUNG),
            new Preparat("bruschete","bruschete pesto",12.78,Domain.Models.Enums.StatusProdus.DISPONIBIL,DimensiuneProdus.MEDIU),
            new Preparat(new(){new("rosii",0),new("mozzarella",StilAlimentar.VEGETARIAN),new("ciuperci",0)},"pizza ","pizza vegetariana",30.65),
            new Preparat(new(){new("carne",StilAlimentar.NICIUNUL),new("mozzarella",StilAlimentar.VEGETARIAN),new("ardei rosu",0)},"Pizza prosciutto","pizza prosciutto",41.68),
            new Preambalat("apa minerala","2l",9.89,DateTime.Today.AddYears(1)),
            new Preambalat("Cooca Cola","2l",12.59,DateTime.Today.AddYears(1))
        };
        public void actualizareProdus(string denumireProdus, Produs produs)
        {
            var el = produse.Find(e => e.Denumire == denumireProdus);
            if (el != null)
            {
                produse[produse.IndexOf(el)] = el;
            }
                
            
        }

        public void adaugaProdus(Produs produs)
        {
            produse.Add(produs);
        }

        public void eliminaProdus(Produs produs)
        {
            produse.Remove(produs);
        }

        public Produs? extrageProdus(string denumireProdus)
        {
            return produse.Find(P => P.Denumire == denumireProdus);
        }

        public List<Produs> extrageProduse()
        {
            return produse;
        }
    }
}
