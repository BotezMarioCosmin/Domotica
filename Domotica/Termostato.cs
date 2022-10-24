using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domotica
{
    internal class Termostato
    {
        //immutabili
        private string id;
        private string produttore;
        private string modello;
        private Caldaia cal;

        //costruttore
        public Termostato(string id1, string produttore1, string modello1, Caldaia cal1)
        {
            id = id1;
            produttore = produttore1;
            modello = modello1;

            setCaldaia(cal1);
            checkEsistenza();
        }

        private void checkEsistenza()
        {
            if (cal != null)
            {
                cal.setModFunzionamento(0);
            }
        }

        private void setCaldaia(Caldaia cal1)
        {
            cal = cal1;
        }

        private Caldaia getCaldaia()
        {
            return cal;
        }

        public string getId()
        {
            return id;
        }

        public string getProduttore()
        {
            return produttore;
        }

        public string getModello()
        {
            return modello;
        }

        public void accendi()
        {
            cal.accendi();
        }

        public void spegni()
        {
            cal.spegni();
        }

        public void setModFunzionamento(int m)
        {
            cal.setModFunzionamento(m);
        }

        public string getModFunzionamento()
        {
            return cal.getModFunzionamentoDescrizione(cal.getModFunzionamento());//restituisce stringa funz in base all'int correlato
        }

        public void setTemperaturaRiscaldamento(float t, int m)
        {
            cal.setTemperaturaRiscaldamento(t, m);
        }

        public void temperaturaRiscaldamentoSu(float t, int m)
        {
            cal.temperaturaRiscaldamentoSu(t, m);
        }

        public void temperaturaRiscaldamentoGiu(float t, int m)
        {
            cal.temperaturaRiscaldamentoGiu(t, m);
        }

        public void setTemperaturaAcqua(float t, int m)//m = modalità funzionamento
        {
            cal.setTemperaturaRiscaldamento(t, m);
        }

        public void temperaturaAcquaSu(float t, int m)
        {
            cal.temperaturaAcquaSu(t, m);
        }

        public void temperaturaAcquaGiu(float t, int m)
        {
            cal.temperaturaAcquaGiu(t, m);
        }

        public float getTemperaturaRiscaldamento()
        {
            return cal.getTemperaturaRiscaldamento();
        }

        public float getTemperaturaAcqua()
        { 
            return cal.getTemperaturaAcqua();
        }
    }
}
