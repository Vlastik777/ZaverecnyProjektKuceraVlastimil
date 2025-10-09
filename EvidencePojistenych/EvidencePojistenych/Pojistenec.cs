using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojistenych
{     
    /// <summary>
    /// Třída reprezentuje správce pojištěných
    /// </summary>
    public class Pojistenec
    {
        /// <summary>
        /// Jméno pojištěnce
        /// </summary>   
        public string Jmeno { get; private set; }

        /// <summary>
        /// Příjmení pojištěnce
        /// </summary>
        public string Prijmeni { get; private set; }

        /// <summary>
        /// Věk pojištěnce
        /// </summary>
        public int Vek { get; private set; }

        /// <summary>
        /// Telefonní číslo pojištěnce
        /// </summary>
        public string TelefonniCislo { get; private set; }

        /// <summary>
        /// Vytvoří novou instanci pojištěnce
        /// </summary>
        /// <param name="jmeno">Jméno pojištěnce</param>
        /// <param name="prijmeni">Příjmení pojištěnce</param>
        /// <param name="vek">Věk pojištěnce</param>
        /// <param name="telefonnicislo">Telefonní číslo pojištěnce</param>
        public  Pojistenec (string jmeno, string prijmeni, int vek, string telefonnicislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelefonniCislo = telefonnicislo;
        }

        /// <summary>
        /// Vrátí textovou reprezentaci pojištěnce
        /// </summary>
        /// <returns>Textová reprezentace pojištěnce</returns>
        public override string ToString()
        {
            return Jmeno + " " + Prijmeni + " " + Vek + " " + TelefonniCislo;
        }
    }
}

    

