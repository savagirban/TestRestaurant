using RestaurantFis.Models.Domain.Interfaces;
using RestaurantFis.Models.Domain.Models;

namespace RestaurantFis.Models.Data.Repositories
{
    public class RepoPlataBD : IRepoPlata
    {
        private List<Plata> plati = new List<Plata>();

        public void adaugaPlata(Plata plata)
        {
            var existingPlata = plati.FirstOrDefault(p => p.IdComanda == plata.IdComanda);
            if (existingPlata == null)
            {
                plati.Add(plata);
                Console.WriteLine($"Plata pentru comanda cu ID-ul '{plata.IdComanda}' a fost adăugată.");
            }
            else
            {
                Console.WriteLine($"Plata pentru comanda cu ID-ul '{plata.IdComanda}' există deja.");
            }
        }

        public void eliminaPlata(string idComanda)
        {
            var plataToDelete = plati.FirstOrDefault(p => p.IdComanda == idComanda);
            if (plataToDelete != null)
            {
                plati.Remove(plataToDelete);
                Console.WriteLine($"Plata pentru comanda cu ID-ul '{idComanda}' a fost ștearsă.");
            }
            else
            {
                Console.WriteLine($"Plata pentru comanda cu ID-ul '{idComanda}' nu a fost găsită.");
            }
        }

        public Plata extragePlata(string idComanda)
        {
            var plata = plati.FirstOrDefault(p => p.IdComanda == idComanda);
            if (plata != null)
            {
                Console.WriteLine($"Plata pentru comanda cu ID-ul '{idComanda}' a fost găsită.");
                return plata;
            }
            else
            {
                Console.WriteLine($"Plata pentru comanda cu ID-ul '{idComanda}' nu a fost găsită.");
                return null;
            }
        }

        public void actualizeazaPlata(string idComanda, Plata plata)
        {
            var plataToUpdate = plati.FirstOrDefault(p => p.IdComanda == idComanda);
            if (plataToUpdate != null)
            {
                plataToUpdate.Suma = plata.Suma;
                plataToUpdate.MetodaPlata = plata.MetodaPlata;
                plataToUpdate.IdTranzactie = plata.IdTranzactie;
                Console.WriteLine($"Plata pentru comanda cu ID-ul '{idComanda}' a fost actualizată.");
            }
            else
            {
                Console.WriteLine($"Plata pentru comanda cu ID-ul '{idComanda}' nu a fost găsită.");
            }
        }

        public bool AdaugaPlata(Plata plata)
        {
            throw new NotImplementedException();
        }

        public bool EliminaPlata(string idComanda)
        {
            throw new NotImplementedException();
        }

        public Plata ExtragePlata(string idComanda)
        {
            throw new NotImplementedException();
        }

        public bool ActualizeazaPlata(string idComanda, Plata plata)
        {
            throw new NotImplementedException();
        }
    }
}
