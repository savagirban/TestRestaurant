using RestaurantFis.Models.Domain.Models.Utilizatori;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFis.Models.Domain.Interfaces
{
    internal interface IAutentificare
    {
        public Utilizator? Autentificare(string username, string parola);
        public bool Deconectare(Utilizator utilizator);
        public string GenereazaToken(Utilizator utilizator);

        public Utilizator? ValidareToken(string token);
    }
}
