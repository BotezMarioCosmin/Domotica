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
        bool muto = false;

        public Telecomando(string produttore1,string modello1, bool infrarossi1, bool bluetooth1, bool wifi1, Tv tv1)
        { 
            produttore = produttore1;
            modello = modello1;

            infrarossi = infrarossi1;
            bluetooth = bluetooth1;
            wifi = wifi1;

            setTv(tv1);
            checkEsistenza();
        }

        private void checkEsistenza()
        {
            if (tv != null)
            {
                tv.setVolume(0);
                tv.setCanale(1);
            }
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
            if (tv != null)
                tv.accendi();
        }

        public void spegniTv()
        {
            if (tv != null)
                tv.spegni();
        }

        public void setCanale(int c)
        {
            if (tv != null)
                tv.setCanale(c);
        }

        public void setVolume(int v)
        {
            if (tv != null)
                tv.setVolume(v);
        }
        public void volumeSu(int v)
        {
            if (tv != null)
                tv.volumeSu(v);
        }

        public void volumeGiu(int v)
        {
            if (tv != null)
                tv.volumeGiu(v);
        }

        public void canaleSu(int c)
        {
            if (tv != null)
                tv.canaleSu(c);
        }

        public void canaleGiu(int c)
        {
            if (tv != null)
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
