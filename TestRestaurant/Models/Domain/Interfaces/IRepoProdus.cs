using RestaurantFis.Models.Domain.Models;

namespace RestaurantFis.Models.Domain.Interfaces
{
    public interface IRepoProdus
    {
        Produs? extrageProdus(string denumireProdus);
        void adaugaProdus(Produs produs);

        void eliminaProdus(Produs produs);

        void actualizareProdus(string denumireProdus, Produs produs);

        List<Produs> extrageProduse();
    }
}
