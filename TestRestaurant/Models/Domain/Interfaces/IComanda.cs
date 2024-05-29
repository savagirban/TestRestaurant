using RestaurantFis.Models.Domain.Models.Utilizatori;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RestaurantFis.Models.Domain.Interfaces
{
    internal interface IComanda
    {
        //TODO: REturneaza Comanda
        public void creazaComanda(Utilizator utilizator);
        public void finalizareComanda(object plata);
    }
}
