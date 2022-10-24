using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domotica
{
    internal class Caldaia
    {
        //immutabili
        private string id;
        private string produttore;
        private string modello;
        private string dataInstallazione;

        //mutabili
        bool stato;
        float temperaturaAcqua;//min 35, max 60
        float temperaturaRiscaldamento;//min 5, max 30
        string[] modFunzionamentoDescrizione = new string[5] {"inattivo", "riscaldamento", "acqua calda", "riscaldamento e acqua calda", "errore"};
        int modFunzionamento;

        //costruttore 
        public Caldaia(string id1, string produttore1, string modello1, string dataInstallazione1)
        {
            id = id1;
            produttore = produttore1;
            modello = modello1;
            dataInstallazione = dataInstallazione1;
        }
        //funzioni
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

        public string getDataInstallazione()
        {
            return dataInstallazione;
        }

        public void accendi()
        {
            stato = true;
        }

        public void spegni()
        {
            stato = false;
        }

        public bool getStato()
        {
            return stato;
        }

        public void setTemperaturaAcqua(float t, int m)//m = modalità funzionamento
        {
            if (m == 2 || m == 3 && t >= 35 && t <= 60)
            {
                temperaturaAcqua = t;
            }
        }

        public float getTemperaturaAcqua()
        {
            return temperaturaAcqua;
        }

        public void temperaturaAcquaSu(float t, int m)
        {
            if (m == 2 || m == 3 && t + 1 <= 60)//t max 60
            {
                temperaturaAcqua++;
            }
        }

        public void temperaturaAcquaGiu(float t, int m)
        {
            if (m == 2 || m == 3 && t - 1 >= 35)//t min 35
            {
                temperaturaAcqua--;
            }
        }

        public void setTemperaturaRiscaldamento(float t, int m)
        {
            if (m == 1 || m == 3 && t >= 35 && t <= 60)
            {
                temperaturaRiscaldamento = t;
            }
        }

        public float getTemperaturaRiscaldamento()
        {
            return temperaturaRiscaldamento;
        }

        public void temperaturaRiscaldamentoSu(float t, int m)
        {
            if (m == 1 || m == 3 && t + 1 <= 60)//t max 30
            {
                temperaturaRiscaldamento++;
            }
        }

        public void temperaturaRiscaldamentoGiu(float t,int m)
        {
            if (m == 1 || m == 3 && t - 1 >= 35)//t min 5
            {
                temperaturaRiscaldamento--;
            }
        }

        public void setModFunzionamento(int m)
        {
            modFunzionamento = m;
        }

        public int getModFunzionamento()//restituisce il numero della mod funz
        {
            return modFunzionamento;
        }

        public string getModFunzionamentoDescrizione(int i)//restituisce la rispettiva stringa dell'int di funz
        {
            return modFunzionamentoDescrizione[i];
        }
    }
}
