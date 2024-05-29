using RestaurantFis.Models.Domain.Models;

namespace RestaurantFis.Models.Domain.Interfaces
{
    public interface IRepoPlata
    {
        public bool AdaugaPlata(Plata plata);
        public Plata ExtragePlata(string idComanda);
    }
}
