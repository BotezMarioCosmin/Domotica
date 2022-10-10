using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domotica
{
    public struct modFunzionamento
    {
        public bool infrarossi;
        public bool bluetooth;
        public bool wifi;
    }
    internal class Telecomando
    {
        int canale;

        private string produttore;
        private string modello;
        

        public Telecomando(string produttore1,string modello1, bool infrarossi1, bool bluetooth1, bool wifi1)
        { 
            produttore = produttore1;
            modello = modello1;

            modFunzionamento m;
            m.infrarossi = infrarossi1;
            m.bluetooth = bluetooth1;
            m.wifi = wifi1;
        }

        public int getCanale()
        {
            return canale;
        }

        public void setCanale(int number)
        {
            canale = number;        
        }

    }
}
