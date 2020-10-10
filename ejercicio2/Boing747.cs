using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2desafio5.ejercicio2
{
    class Boing747 : Avion, Volador
    {

        public int horasDeVuelo = 0;

        public void volar()
        {
            horasDeVuelo += 13;
            Console.WriteLine("Estoy volando como un avión...");
        }
    }
}
