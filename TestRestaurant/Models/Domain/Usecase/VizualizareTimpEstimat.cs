using RestaurantFis.Models.Domain.Interfaces;
using RestaurantFis.Models.Domain.Models;
using RestaurantFis.Models.Domain.Models.Utilizatori;
using RestaurantFis.Models.Mock.Data.Repos;

namespace RestaurantFis.Models.Domain.Usecase
{
    public class VizualizareTimpEstimat
    {
        private Client client;

        private string idComanda;

        public IRepoComanda RepoComanda { get; set; }

        public VizualizareTimpEstimat (IRepoComanda c, Client client, string idComanda)
        {
            this.client = client;
            RepoComanda=c;
            this.idComanda = idComanda;
            
        }
        public VizualizareTimpEstimat(IRepoComanda c, Client client, Comanda comanda)
        {
            RepoComanda = c;
            this.client = client;
            this.idComanda = comanda.Idcomanda;
        }

        public int TimpEstimat()
        {
            //TODO: MAKE REpo work
            return 5;
        }
    }
}
