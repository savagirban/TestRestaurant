using RestaurantFis.Models.Domain.Interfaces;
using RestaurantFis.Models.Domain.Models.Utilizatori;
using RestaurantFis.Models.Mock.Data.Repos;

namespace RestaurantFis.Models.Domain.Usecase
{
    public class InregistrareClient
    {
        private Utilizator utilizator;

        public IRepoUtilizator repoClienti { get; set; } = new MockRepoUtilizator();
        public InregistrareClient(
            string username,
            string parola, 
            string email, 
            string nume, 
            string prenume) {
            utilizator = new Client(username:username, parola:parola, email:email, nume:nume,prenume:prenume);
           }
        public Utilizator? Inregistrare()
        {
            var client = repoClienti.extrageUtilizator(utilizator.Username);
            if (client != null) return null;
            repoClienti.adaugaUtilizator(utilizator);
            return utilizator;
        }
    }
}
