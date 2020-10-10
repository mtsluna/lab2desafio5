using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2desafio5.ejercicio2
{
    class Superman : SuperHeroe, Volador
    {

        public int experiencia = 0;

        public void volar()
        {
            Console.WriteLine("Estoy volando como un campeón...");
            experiencia += 3;
        }
    }
}
