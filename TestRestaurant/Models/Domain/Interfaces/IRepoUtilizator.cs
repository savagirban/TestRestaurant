using RestaurantFis.Models.Domain.Models.Utilizatori;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFis.Models.Domain.Interfaces
{
    public interface IRepoUtilizator
    {
        public Utilizator? extrageUtilizator(string username);
        public void adaugaUtilizator(Utilizator utilizator);
        public void eliminaUtilizator(Utilizator utilizator);
        public void actualizareUtilizator(string username, Utilizator utilizator);
    }
}
