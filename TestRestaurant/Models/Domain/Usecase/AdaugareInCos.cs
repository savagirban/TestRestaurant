using RestaurantFis.Models.Domain.Interfaces;
using RestaurantFis.Models.Domain.Models;
using RestaurantFis.Models.Domain.Models.Utilizatori;

namespace RestaurantFis.Models.Domain.Usecase
{
    public class AdaugareInCos:IUsecase
    {
        #region Proprietati

        private readonly Client client;
        private readonly Produs produs;
        #endregion
        public AdaugareInCos(Client client, Produs produs)
        {
            this.client = client;
            this.produs = produs;
        }

        public void ExecuteUsecase()
        {
            if (client.Cos.Elemente.Any(e => e.Produs == produs))
            {
                int ind = client.Cos.Elemente.FindIndex(e=>e.Produs == produs);
                client.Cos.Elemente[ind].Cantitate += 1;
            }
            else
            {
                client.Cos.adaugaElement(new ElementComanda(produs, 1));
            }
        }
    }
}
