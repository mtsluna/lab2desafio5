using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2desafio5.ejercicio2
{
    class TorreDeControl
    {
        public List<Volador> voladores = new List<Volador>();

        public void vuelenTodos()
        {
            foreach (var item in voladores)
            {
                item.volar();
            }
        }

        public void agregarVolador(Volador unVolador)
        {
            voladores.Add(unVolador);
        }
    }
}
