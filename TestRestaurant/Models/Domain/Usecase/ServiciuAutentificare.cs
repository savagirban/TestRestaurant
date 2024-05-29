using RestaurantFis.Models.Domain.Interfaces;
using RestaurantFis.Models.Domain.Models;
using RestaurantFis.Models.Domain.Models.Utilizatori;

namespace RestaurantFis.Models.Domain.Usecase
{
    public class ServiciuAutentificare : IAutentificare
    {
        private IRepoUtilizator repoUtilizator;

        public ServiciuAutentificare(IRepoUtilizator repoUtilizator)
        {
            this.repoUtilizator = repoUtilizator;
        }
        public Utilizator? Autentificare(string username, string parola)
        {
            Utilizator? utilizator;
           if((utilizator=repoUtilizator.extrageUtilizator(username))!=null)
            {
                PasswordEncryptor encryptor = new(parola);
                if(utilizator.Parola==parola)
                {
                    return utilizator;
                }
                else
                {
                    FileLogger.Write("AUTH: Password does not match.");
                    return null;
                }
            }
            else
            {
                FileLogger.Write("AUTH: Unexisting/Invalid user tried to auth.");
                return null;
            }
        }

        public bool Deconectare(Utilizator utilizator)
        {
            throw new NotImplementedException();
        }

        public string GenereazaToken(Utilizator utilizator)
        {
            throw new NotImplementedException();
        }

        public Utilizator? ValidareToken(string token)
        {
            throw new NotImplementedException();
        }
    }
}
