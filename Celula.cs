using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tstebateria
{
    internal class Celula
    {
        private float carga = 25f;
        private static float cargaBateria;

        

        public float GetCarga()
        {
            return carga;
        }

        public float GetCargaBateria()
        {
            cargaBateria = carga * 4;
            return cargaBateria;
        }

        public void Consumir()
        {
            carga -= 5f;
           
        }


        public void Carregar()
        {
            carga += 5f;
            
        }

    }
}
