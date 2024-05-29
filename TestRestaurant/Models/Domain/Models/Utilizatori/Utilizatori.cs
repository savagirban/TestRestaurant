using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFis.Models.Domain.Models.Utilizatori
{
    public abstract class Utilizator
    {

        #region Campuri

        private string? nume;
        private string? prenume;
        private string email;
        private string parola;
        private string username;
        private Guid id = new Guid();
        protected Utilizator(string nume, string prenume, string email, string parola, string username)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.email = email;
            this.parola = parola;
            this.username = username;
        }

        #endregion Campuri

        #region Proprieatati
        public string Nume { get => nume; set => nume = value; }
        public string Prenume { get => prenume; set => prenume = value; }
        public string Email { get => email; set => email = value; }
        public string Parola { get => parola; set => parola = value; }
        public string Username { get => username; set => username = value; }

        public override bool Equals(object? obj)
        {
            return obj is Utilizator utilizator &&
                   username == utilizator.username;
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
        #endregion Proprietati

        #region Constructor

        #endregion Constructor
    }
}
