using lab2desafio5.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2desafio5.ejercicio1
{
    class Impresora
    {

        public List<Imprimible> ColaDeImpresion = new List<Imprimible>();

        public void ImprimirTodo()
        {
            foreach (var item in ColaDeImpresion)
            {
                item.Imprimir();
            }
        }

        public void AgregarImprimible(Imprimible unImprimible)
        {
            ColaDeImpresion.Add(unImprimible);
        }

    }
}
