using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojistenych
{
    /// <summary>
    /// Třida reprezentuje komunikaci s uživatelem
    /// </summary>
    class PojistenciKonzola
    {
        private Pojistenci pojistenci;
        public PojistenciKonzola()
        {
            pojistenci = new Pojistenci();
        }

        /// <summary>
        /// Vypíše ůvodnní obrazovku programu
        /// </summary>
        public void VypisUvodniObrazovku()
        {
            Console.Clear();
            Console.WriteLine("******************************");
            Console.WriteLine("Evidence pojistených");
            Console.WriteLine("******************************");
        }

        /// <summary>
        /// Vyzve uživatele k přidání záznamu a uloží ho do pojištěnci 
        /// </summary>
        public void PridejZaznam()
        {
            Console.WriteLine("Zadejte jméno: ");
            string jmeno1, prijmeni1, vek1, telefonnicislo1;
            vek1 = "";
            while (string.IsNullOrWhiteSpace(jmeno1 = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte jméno znovu:");
            }

            Console.WriteLine("Zadejte příjmení: ");
            while (string.IsNullOrWhiteSpace(prijmeni1 = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte příjmení znovu:");
            }

            Console.WriteLine("Zadejte věk: ");
            while (string.IsNullOrWhiteSpace(vek1 = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte věk znovu:");
            }

            Console.WriteLine("Zadejte telefonní číslo: ");
            while (string.IsNullOrWhiteSpace(telefonnicislo1 = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte telefonní číslo znovu:");
            }
            pojistenci.PridejPojistence(jmeno1, prijmeni1, vek1, telefonnicislo1);
        }

        /// <summary>
        /// Vyzve uživatele k zadání ůdajů za ůčelem nalezení záznamu  
        /// </summary>
        public void NajdiZaznam()
        {
            Console.WriteLine("Zadejte jméno: ");
            string jmeno1, prijmeni1;
            
            while (string.IsNullOrWhiteSpace(jmeno1 = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte jméno znovu:");
            }

            Console.WriteLine("Zadejte příjmení: ");
            while (string.IsNullOrWhiteSpace(prijmeni1 = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte příjmení znovu:");
            }
            
            List<Pojistenec> zaznamy = pojistenci.NajdiPojistence(jmeno1, prijmeni1);
            // Výpis záznamů
            if (zaznamy.Count() > 0)
            {
                Console.WriteLine("Nalezeny tyto záznamy: ");
                foreach (Pojistenec z in zaznamy)
                    Console.WriteLine(z);
            }
            else
                // Nenalezeno
                Console.WriteLine("Nebyly nalezeny žádné záznamy.");
        }

        /// <summary>
        /// Budou vymazány záznamy pro zadaneé jméno a příjmení 
        /// </summary>
        public void VymazZaznam()
        {
            Console.WriteLine("Budou vymazány záznamy pro zadané jméno a příjmení");
            Console.WriteLine("Zadejte jméno: ");
            string jmeno1, prijmeni1;

            while (string.IsNullOrWhiteSpace(jmeno1 = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte jméno znovu:");
            }

            Console.WriteLine("Zadejte příjmení: ");
            while (string.IsNullOrWhiteSpace(prijmeni1 = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte příjmení znovu:");
            }

            pojistenci.ZrusPojistence(jmeno1, prijmeni1);
        }
    }
}
