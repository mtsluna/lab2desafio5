using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2desafio5.ejercicio2
{
    class Pato : Animal, Volador
    {

        public int energia = 0;

        public void volar()
        {
            this.energia -= 5;
            Console.WriteLine("Estoy volando como un pato... ¡Cuak!");
        }
    }
}
