using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojistenych
{
    /// <summary>
    /// Třída spravuje kolekci pojištěnců
    /// </summary>
    public class Pojistenci
    {
        /// <summary>
        /// Kolekce pojištěncú
        /// </summary>
        private List<Pojistenec> pojistenci;

        /// <summary>
        /// Vytvoří novou instanci pojištěnců
        /// </summary>
        public Pojistenci()
        { 

            pojistenci = new List<Pojistenec>();
        }
        
       /// <summary>
       /// Přidá nový záznam do pojištěnci
       /// </summary>
       /// <param name="jmeno1"></param>
       /// <param name="prijmeni1"></param>
       /// <param name="vek1"></param>
       /// <param name="telefonnicislo1"></param>
        public void PridejPojistence(string jmeno1, string prijmeni1, string vek1, string telefonnicislo1) 
        {

            pojistenci.Add(new Pojistenec(jmeno1, prijmeni1,  int.Parse(vek1), telefonnicislo1));
        }

        /// <summary>
        /// Najde nový záznam pojištěnce
        /// </summary>
        /// <param name="jmeno">Jméno pojištěnce</param>
        /// <param name="prijmeni">Příjmení pojištěnce</param>
        /// <returns></returns>
        public List<Pojistenec> NajdiPojistence(string jmeno, string prijmeni)
        {
            List<Pojistenec> nalezene = new List<Pojistenec>(); 
            foreach (Pojistenec pojistenec in pojistenci)
            {
                if (pojistenec.Jmeno == jmeno && pojistenec.Prijmeni == prijmeni)

                    nalezene.Add(pojistenec);  
            }
            return nalezene;
        }

        /// <summary>
        /// Vymaže pojištěnce           
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        public void ZrusPojistence(string jmeno, string prijmeni)
        {
            List<Pojistenec> nalezeno = NajdiPojistence(jmeno, prijmeni);
            foreach (Pojistenec z in nalezeno)
                pojistenci.Remove(z);
        }

        /// <summary>
        /// Vypíše pojištěnce
        /// </summary>
        public void VypisPojistence() 
        {
            for (int i = 0; i < pojistenci.Count; i++) 
            {
                Pojistenec pojistenec1 = pojistenci[i];  
               Console.WriteLine(pojistenec1); 
            }
        }
    }
}
