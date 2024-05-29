using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantFis.Models.Domain.Interfaces;
using RestaurantFis.Models.Domain.Models.Enums;

namespace RestaurantFis.Models.Domain.Models
{
    internal class PlataCard : Plata, IProcesarePlataCard
    {
        private string numarCard;
        DateTime dataExpirare;
        private string ccv;

        public PlataCard(string idComanda, double suma, MetodaPlata metodaplata, string? idTranzactie) : base(idComanda, suma, metodaplata, idTranzactie)
        {
            numarCard = numarCard;
            dataExpirare = dataExpirare;
            ccv = ccv;
        }

        public PlataCard(string numarCard, DateTime dataExpirare, string ccv, string idComanda, double suma, MetodaPlata metodaplata, string? idTranzactie) : base(idComanda, suma, metodaplata, idTranzactie)
        {
            this.numarCard = numarCard;
            this.dataExpirare = dataExpirare;
            this.ccv = ccv;
        }


        public string NumarCard { get { return numarCard; } set { numarCard = value; } }
        public DateTime DataExpirare { get { return dataExpirare; } set { dataExpirare = value; } }
        public string Ccv { get { return ccv; } set { ccv = value; } }

        public bool procesarePlataCard(PlataCard plata)
        {
            throw new NotImplementedException();
        }
    }
}
