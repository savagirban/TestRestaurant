using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantFis.Models.Domain.Models;

namespace RestaurantFis.Models.Domain.Models.Utilizatori
{
    /// <summary>
    /// Definirea clasei Client care mosteneste Utilizator
    /// </summary>
    public class Client : Utilizator
    {
        #region Campuri
        private bool acceptareTermeni;
        private Cos cos;

        public Client(string nume, string prenume, string email, string parola, string username) : base(nume, prenume, email, parola, username)
        {
            cos = new Cos();
        }
        #endregion


        public bool AcceptareTermeni { get => acceptareTermeni; set => acceptareTermeni = value; }
        internal Cos Cos { get => cos; set => cos = value; }
    }
}
