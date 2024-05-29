using RestaurantFis.Models.Domain.Interfaces;
using RestaurantFis.Models.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using user=RestaurantFis.Models.Domain.Models.Utilizatori;
namespace RestaurantFis.Models.Domain.Models
{
    public class Comanda : IComanda
    {
        List<ElementComanda> elementComanda;
        private StatusComanda statusComanda;
        private string utilizator;
        private Personal? personal;
        private string idcomnada;

        public Comanda(List<ElementComanda> elementComanda, StatusComanda statusComanda, string utilizator, Personal? personal, string idcomnada)
        {
            this.elementComanda = elementComanda;
            this.statusComanda = statusComanda;
            this.utilizator = utilizator;
            this.personal = personal;
            this.idcomnada = idcomnada;
        }
        public Comanda(List<ElementComanda> elementComanda, StatusComanda statusComanda, string utilizator, string idcomnada)
        {
            this.elementComanda = elementComanda;
            this.statusComanda = statusComanda;
            this.utilizator = utilizator;
            this.personal = null;
            this.idcomnada = idcomnada;
        }

        internal List<ElementComanda> ElementComanda { get { return elementComanda; } set { elementComanda = value; } }

        public StatusComanda StatusComanda { get { return statusComanda; } set { statusComanda = value; } }

        public user.Utilizator Utilizator { get; set; }

        public string Username { get => utilizator; set => utilizator = value; }

        public Personal Personal { get { return personal; } set { personal = value; } }

        public string Idcomanda { get { return idcomnada; } set { idcomnada = value; } }

        public string TimpEstimat { get;set; }
        void IComanda.creazaComanda(user.Utilizator utilizator)
        {
            throw new NotImplementedException();
        }

        void IComanda.finalizareComanda(object plata)
        {
            throw new NotImplementedException();
        }

        public override string? ToString()
        {
            return "Comanda:{ " + $"{idcomnada}|{utilizator}->{statusComanda} produse" + " }";
        }
    }
}
