using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domotica
{
    public class Tv
    {
        //immutabili
        string produttore, modello;
        float potenza; //watt
        int pollici;
        int pixelAltezza, pixelLunghezza;
        string tipologiaPannello;
        bool ethernet, wifi; //presenza di scheda di rete wireless
        int quantitaPorteHDMI;

        //mutabili
        bool stato;
        int canaleSel, volume, luminosita;
        bool statoRete; //connesso o non connesso

        public Tv(string produttore1, string modello1, float potenza1, int pollici1, int pixelAltezza1, int pixelLunghezza1, string tipologiaPannello1, bool ethernet1, bool wifi1, int quantitaPorteHdmi1)
        {
            produttore = produttore1;
            modello = modello1;

            potenza = potenza1;
            pollici = pollici1;
            pixelAltezza = pixelAltezza1;
            pixelLunghezza = pixelLunghezza1;
            tipologiaPannello = tipologiaPannello1;
            ethernet = ethernet1;
            quantitaPorteHDMI = quantitaPorteHdmi1;
        }

        public void accendi()
        {
            stato = true;
        }

        public void spegni()
        {
            stato = false;
        }

        public void canale(int numero)
        {
            canaleSel = numero;
        }

        public void canalePiu(int c)
        {
            if (c + 1 < 1000)
            {
                canaleSel++;
            } 
        }

        public void canaleMeno(int c)
        {
            if (c - 1 > 0)
            {
                canaleSel--;
            }
        }

        public void aumentaVolume(int v)
        {
            if (v + 1 < 1000)
            {
                volume++;
            }
        }

        public void diminuisciVolume(int v)
        {
            if (v - 1 >= 0)
            {
                volume--;
            }
        }

        public void Rete()
        { //accende la connessione WIFI
            if (statoRete == false)
            {
                statoRete = true;
            }
            else
                statoRete = false;
        }
    }
}
