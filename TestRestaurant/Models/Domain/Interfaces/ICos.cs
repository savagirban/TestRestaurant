using RestaurantFis.Models.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFis.Models.Domain.Interfaces
{
    internal interface ICos
    {
        public bool adaugaElement(ElementComanda element);
        public bool eliminaElement(ElementComanda element);
        public bool actualizareCantitate(ElementComanda element, int cantitate);
        public double calculeazaTotal();
    }
}
