using RestaurantFis.Models.Domain.Interfaces;
using RestaurantFis.Models.Domain.Models.Utilizatori;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFis.Models.Mock.Data.Repos
{
    internal class MockRepoUtilizator : IRepoUtilizator
    {

        private List<Utilizator> utilizatori = new List<Utilizator>() {
        new Client(nume:"Bratosin", prenume:"Denisa",username:"denisain",email:"bratosindeni@gmail.com",parola:"parola"),
        new Client(nume:"Nistor", prenume:"Vlad",username:"vlador",email:"nistorvlad@gmail.com",parola:"1234"),
        new Client(nume:"Narcisa", prenume:"Dumitru",username:"narcisa",email:"narcisa.dumitru@yahoo.com",parola:"abc"),
        };
        void IRepoUtilizator.actualizareUtilizator(string username, Utilizator utilizator)
        {
            int? index = utilizatori.FindIndex(utilizator => utilizator.Username == username);
            if (index != null)
            {
                utilizatori[index ?? -1] = utilizator;
            }

        }

        void IRepoUtilizator.adaugaUtilizator(Utilizator utilizator)
        {
            utilizatori.Add(utilizator);
        }

        void IRepoUtilizator.eliminaUtilizator(Utilizator utilizator)
        {
            utilizatori.Remove(utilizator);
        }

        Utilizator? IRepoUtilizator.extrageUtilizator(string username)
        {
            return utilizatori.FirstOrDefault(utilizator => utilizator.Username == username);
        }
    }
}
