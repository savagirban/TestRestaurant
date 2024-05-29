using RestaurantFis.Models.Domain.Models;

namespace RestaurantFis.Models.Domain.Interfaces
{
    public interface IRepoComanda
    {
        public Comanda? extrageComanda(string idcomanda);
        public void adaugaComanda(Comanda idcomanda);
        public void eliminaComanda(Comanda idcomanda);
        public void actualizareComanda(string idcomanda, Comanda comanda);
    }
}
