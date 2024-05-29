using RestaurantFis.Models.Domain.Interfaces;
using RestaurantFis.Models.Domain.Models.Utilizatori;

namespace RestaurantFis.Models.Data.Repositories
{
    public class RepoUtilizatorJson:IRepoUtilizator
    {

        private List<Utilizator> utilizatori = new List<Utilizator>();
        public RepoUtilizatorJson()
        {

        }

      

        public void actualizareUtilizator(string username, Utilizator utilizator)
        {
            throw new NotImplementedException();
        }

        public void adaugaUtilizator(Utilizator utilizator)
        {
            throw new NotImplementedException();
        }

        public void eliminaUtilizator(Utilizator utilizator)
        {
            throw new NotImplementedException();
        }

        public Utilizator? extrageUtilizator(string username)
        {
            throw new NotImplementedException();
        }
    }
}
