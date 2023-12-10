using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h22
{
    enum nasjonalitet { Norge, Danmark, Storbritania }; // er dette ok i forhold til oppgave teksten  og hvorfor er den merket med rød 

    internal class OljeFelt
    {
        public string feltNavn;
        public string eier;
        public int gjenvaerendeOljeMengde;  
        public static double oljePris; // skal ikke tilhør enoe spesefikt objekt men være felles for klassen 
        nasjonalitet land;

        

        public OljeFelt(string feltNavn, string eier, int gjenvaerendeOljeMengde)
        {
            this.feltNavn = feltNavn;
            this.eier = eier;
            this.gjenvaerendeOljeMengde = gjenvaerendeOljeMengde;
        }

        public int GjenvaerendeOljeMengde // skal ikke tillates sett til negativ verdi da skal det settes til 0
        {
            get { return gjenvaerendeOljeMengde; }
            set { if (gjenvaerendeOljeMengde < 0) value = 0; }
        }

        public string FeltNavn // skal ikke tillates sett til blank eller null da skal det komme feilmelding 
        {
            get { return feltNavn; }
            set { if (feltNavn == null || feltNavn == "") value = "Ukjent"; }
        }

        public string Eier
        {
            get { return eier; }
            set { eier = value; }
        }

        public double OljePris
        {
            get { return oljePris; }
            set { oljePris = value; }
        }

        public double ØkonomiskFeltVerdi() // skal noe inni parantesen her ? 
        {
            return gjenvaerendeOljeMengde * oljePris;
        }   

        public override string ToString()
        {
            return "FeltNavn: " + feltNavn + " Eier: " + eier + " GjenvaerendeOljeMengde: " + gjenvaerendeOljeMengde + "Millioner fat" +" OljePris: " + oljePris;
        }
        
        public bool SammeEierSom(OljeFelt felt) // funksjonsmedlem sammeeiersom som har et tilsvarende objekt som argument og returnerer true om det er samme eier
        {
            if (felt.eier == this.eier)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // oppg H
        public string kuk (int gjenvaerendeOljeMengde, string feltNavn, string eier, string land)
        {
            gjenvaerendeOljeMengde = GjenvaerendeOljeMengde;
            feltNavn = FeltNavn;
            eier = Eier;
            land = Land;

        }
        
        public string seb (string feltNavn)
        {

        }




        




            

    }
}
