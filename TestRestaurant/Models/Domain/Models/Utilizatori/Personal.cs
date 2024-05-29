using RestaurantFis.Models.Domain.Models.Enums;

namespace RestaurantFis.Models.Domain.Models.Utilizatori
{
    public class Personal : Utilizator
    {
        private RolAngajat rol;
        public Personal(string nume, string prenume, string email, string parola, string username) : base(nume, prenume, email, parola, username)
        {
        }

        public RolAngajat Rol { get => rol; set => rol = value; }
    }
}
