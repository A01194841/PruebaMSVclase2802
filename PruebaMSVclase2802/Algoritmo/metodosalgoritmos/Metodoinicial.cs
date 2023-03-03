using PruebaMSVclase2802.Algoritmo.Clase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMSVclase2802.Algoritmo.metodosalgoritmos
{
    public class Metodoinicial
    {
        public Metodoinicial() 
        {
        }
        public double AlgoritmoMedia(List<Demanda> listaDemanda)
        {
            double media = 0, suma = 0;
            foreach (Demanda demanda in listaDemanda) 
            {
                suma = suma + demanda.Cantidad;
            }
            media = suma / listaDemanda.Count;
            return media;
        }
        public List<Demanda> LlenarDatosListaDemanda()
        {
            List<Demanda> listaInicial = new List<Demanda>();
            Demanda demanda1 = new Demanda("1","01",20);
            Demanda demanda2 = new Demanda("2","01",40);
            Demanda demanda3 = new Demanda("3","01",30);
            listaInicial.Add(demanda1);
            listaInicial.Add(demanda2);
            listaInicial.Add(demanda3); 
            return listaInicial; 
        }
        public double algoritmoMain() 
        {
            double media = 0;
            List<Demanda> lista = LlenarDatosListaDemanda();
            media = AlgoritmoMedia(lista);
            return media;
        }
    }
}
