using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bateria1
{
    internal class Celula
    {
        private float carga = 25f;
        private static float cargaBateria = 100f;

        

        public float GetCarga()
        {
            return carga;
        }

        public float GetCargaBateria()
        {
            return cargaBateria;
        }

        public void Consumir()
        {
            carga -= 5f;
            cargaBateria -= 5f;
        }


        public void Carregar()
        {
            carga += 5f;
            cargaBateria += 5f;
        }

    }
}
