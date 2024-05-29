using RestaurantFis.Models.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFis.Models.Domain.Models
{
    public class Plata
    {
        #region Campuri
        private string idComanda;
        private double suma;
        private MetodaPlata metodaplata;
        private string? idTranzactie;

        public Plata()
        {
        }

        public Plata(string idComanda, double suma, MetodaPlata metodaplata, string? idTranzactie)
        {
            this.idComanda = idComanda;
            this.suma = suma;
            this.metodaplata = metodaplata;
            this.idTranzactie = idTranzactie;
        }

        public string IdComanda { get { return idComanda; } set { idComanda = value; } }
        public double Suma { get { return suma; } set { suma = value; } }
        internal MetodaPlata MetodaPlata { get { return metodaplata; } set { metodaplata = value; } }
        public string? IdTranzactie { get { return idTranzactie; } set { idTranzactie = value; } }
        #endregion
    }
}
