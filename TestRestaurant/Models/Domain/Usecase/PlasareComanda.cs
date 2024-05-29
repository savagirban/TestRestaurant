using RestaurantFis.Models.Domain.Interfaces;
using RestaurantFis.Models.Domain.Models;
using RestaurantFis.Models.Domain.Models.Enums;
using RestaurantFis.Models.Domain.Models.Utilizatori;

namespace RestaurantFis.Models.Domain.Usecase
{
    public class PlasareComanda
    {
        private Client client;

        private IRepoComanda repoComanda;
        public PlasareComanda(Client client, IRepoComanda repo)
            { this.client = client;
            this.repoComanda = repo;
        }

        public Comanda PlaseazaComanda()
        {
            Comanda comanda = new(client.Cos.Elemente, StatusComanda.InAsteptare, client.Username, null, new Guid().ToString());
            //TODO: adauga comanda la repo
            return comanda;
        }
    }
}
