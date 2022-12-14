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
        private string _id; //PK, Primary Key
        private string _produttore, _modello;
        private float _prezzo;
        private float potenza; //watt
        private int pollici;
        private int pixelAltezza, pixelLunghezza;
        private string tipologiaPannello;
        private bool ethernet, wifi; //presenza di scheda di rete wireless
        private int quantitaPorteHDMI;

        //mutabili
        bool stato;
        int canale, volume, luminosita;
        bool statoRete; //connesso o non connesso
        
        public Tv(string id1, string produttore1, string modello1, float potenza1, int pollici1, int pixelAltezza1, int pixelLunghezza1, string tipologiaPannello1, bool ethernet1, bool wifi1, int quantitaPorteHdmi1, float prezzo1)
        {
            _id = id1;
            _produttore = produttore1;
            _modello = modello1;
            _prezzo = prezzo1;

            potenza = potenza1;
            pollici = pollici1;
            pixelAltezza = pixelAltezza1;
            pixelLunghezza = pixelLunghezza1;
            tipologiaPannello = tipologiaPannello1;
            ethernet = ethernet1;
            quantitaPorteHDMI = quantitaPorteHdmi1;
        }

        public float Prezzo//proprietà prezzo
        {
            set
            {
                if (value > 0)
                {
                    _prezzo = value;
                }
            }

            get
            {
                return _prezzo;
            }
        }

        public string Id//proprietà id
        {
            set
            {
                _id = value;
            }

            get
            {
                return _id;
            }
        }

        public string Produttore//proprietà produttore
        {
            set
            {
                _produttore = value;
            }

            get
            {
                return _produttore;
            }
        }
        public string Modello//proprietà modello
        {
            set
            {
                _modello = value;
            }

            get
            {
                return _modello;
            }
        }

        public void accendi()
        {
            stato = true;
        }

        public void spegni()
        {
            stato = false;
        }

        public int getCanale()
        {
            return canale;
        }

        public void setCanale(int c)
        {
            canale = c;
        }

        public int getVolume()
        {
            return volume;
        }

        public void setVolume(int v)
        {
            volume = v;
        }

        public void canaleSu(int c)
        {
            if (c + 1 < 1000)
            {
                canale++;
            }
            else if (c + 1 > 999)
                canale = 1;
        }

        public void canaleGiu(int c)
        {
            if (c - 1 > 0)
            {
                canale--;
            }
        }

        public void volumeSu(int v)
        {
            if (v + 1 < 100)
            {
                volume++;
            }
        }

        public void volumeGiu(int v)
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
