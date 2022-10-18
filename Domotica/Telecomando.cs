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
        Tv tv = new Tv("samsung", "qled", 50, 55, 1080, 1920, "ips", true, true, 4);
        //mutabili
        bool muto = false;

        public Telecomando(string produttore1,string modello1, bool infrarossi1, bool bluetooth1, bool wifi1)
        { 
            produttore = produttore1;
            modello = modello1;

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
            tv.accendi();
        }

        public void spegniTv()
        {
            tv.spegni();
        }

        public int getCanaleTv()
        {
            return tv.getCanale();
        }

        public void setCanaleTv(int c)
        {
            tv.setCanale(c);
        }

        public int getVolumeTv()
        {
            return tv.getVolume();
        }

        public void setVolumeTv(int v)
        {
            tv.setVolume(v);
        }
        public void volumeSu(int v)
        {
            tv.volumeSu(v);
        }

        public void volumeGiu(int v)
        {
            tv.volumeGiu(v);
        }

        public void canaleSu(int c)
        {
            tv.canaleSu(c);
        }

        public void canaleGiu(int c)
        {
            tv.canaleGiu(c);
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
