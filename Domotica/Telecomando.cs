using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domotica
{
    public class Telecomando
    {
        //immutabili
        private string produttore;
        private string modello;
        private bool infrarossi;
        private bool bluetooth;
        private bool wifi;
        private Tv tv;

        //mutabili
        bool TvStatus = false;
        int canale = 0, volume = 0;
        bool muto = false;

        public Telecomando(string produttore1,string modello1, bool infrarossi1, bool bluetooth1, bool wifi1)
        { 
            produttore = produttore1;
            modello = modello1;

            volume = 10;
            canale = 0;
            infrarossi = infrarossi1;
            bluetooth = bluetooth1;
            wifi = wifi1;
        }

        private void setTv(Tv tv1)
        {
            tv = tv1;
        }

        private Tv getTv()
        {
            return tv;
        }

        public string getProduttore()
        {
            return produttore;
        }

        public string getModello()
        {
            return modello;
        }

        public string getModFunzionamento()
        {
            string i, b, w;
            if (infrarossi == true)
            {
                i = "infrarossi/";
            }
            else
                i = null;

            if (bluetooth == true)
            {
                b = "bluetooth/";
            }
            else
                b = null;

            if (wifi == true)
            {
                w = "wifi/";
            }
            else
                w = null;

            return i + b + w;
        }

        public void accendiTv()
        {
            //tv.accendi();
            TvStatus = true;
        }

        public void spegniTv()
        {
            //tv.spegni();
            TvStatus = false;
        }

        public int getCanale()
        {
            return canale;
        }

        public void setCanale(int number)
        {
            canale = number;        
        }

        public int getVolume()
        {
            return volume;
        }

        public void setVolume(int number)
        {
            volume = number;
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

        public void canaleSu(int c)
        {
            if (c + 1 < 1000)
            {
                canale++;
            }
        }

        public void canaleGiu(int c)
        {
            if (c - 1 > 0)
            {
                canale--;
            }
        }

        public bool volumeMuto()
        {
            if (muto == false)
            {
                muto = true;
                return muto;
            }
            else
            {
                muto = false;
                return muto;
            }
        }
    }
}
