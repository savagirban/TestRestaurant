using RestaurantFis.Models.Domain.Interfaces;
using RestaurantFis.Models.Domain.Models;

namespace RestaurantFis.Models.Mock.Data.Repos
{
    public class MockRepoComanda : IRepoComanda
    {
        List<Comanda> comenzi = new()
        {
            new(new(){new(new Preambalat("Apa minerala","apa minerala carbogazoasa",12.0,DateTime.Today),1)},Domain.Models.Enums.StatusComanda.InAsteptare,"vlador","c01"),
            new(new(){new(new Preambalat("Apa plata","apa plata 2L",23.0,DateTime.Today),1)},Domain.Models.Enums.StatusComanda.InAsteptare,"vlador","c02"),

        };
       
        public void actualizareComanda(string idcomanda, Comanda comanda)
        {
            Comanda? comand = comenzi.Find(c => c.Idcomanda ==idcomanda);
            if(comand!=null)
            {
                comenzi[comenzi.IndexOf(comand)] = comanda;
            }
        }

        public void adaugaComanda(Comanda idcomanda)
        {
            comenzi.Add(idcomanda);
        }

        public void eliminaComanda(Comanda idcomanda)
        {
            comenzi.Remove(idcomanda);
        }

        public Comanda? extrageComanda(string idcomanda)
        {
            return comenzi.Find(c=>c.Idcomanda==idcomanda);
        }
    }
}
