using RestaurantFis.Models.Domain.Models;

namespace RestaurantFis.Models.Domain.Interfaces
{
    internal interface IProcesarePlataCard
    {
        public bool procesarePlataCard(PlataCard plata);
    }
}