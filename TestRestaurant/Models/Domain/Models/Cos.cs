using RestaurantFis.Models.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFis.Models.Domain.Models
{
    internal class Cos : ICos
    {
        private List<ElementComanda> elemente;

        public Cos()
        {
            elemente = new List<ElementComanda>();
        }

        internal List<ElementComanda> Elemente { get => elemente; set => elemente = value; }

        public bool actualizareCantitate(ElementComanda element, int cantitate)
        {
            throw new NotImplementedException();
        }

        public bool adaugaElement(ElementComanda element)
        {
            if (elemente == null|| element==null) return false;

            if(elemente.Contains(element))
            {
                elemente[elemente.IndexOf(element)].Cantitate+=1;
                return true;
            }
            else
            {
                elemente.Add(element);
                return true;
            }
        }

        public double calculeazaTotal()
        {
            double suma = 0;
            foreach(var element in elemente)
            {
                suma += element.Cantitate * element.Produs.Pret;
            }
            return suma;
        }

        public bool eliminaElement(ElementComanda element)
        {
            return elemente.Remove(element);
        }
    }
}
