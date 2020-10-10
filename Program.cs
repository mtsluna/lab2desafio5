using lab2desafio5.ejercicio1;
using lab2desafio5.ejercicio2;
using lab2desafio5.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2desafio5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("============Ejercicio 1============");

            Contrato contrato = new Contrato();
            Foto foto = new Foto();
            Documento documento = new Documento();

            Impresora impresora = new Impresora();
            impresora.AgregarImprimible(contrato);
            impresora.AgregarImprimible(foto);
            impresora.AgregarImprimible(documento);

            impresora.ImprimirTodo();

            Console.WriteLine("============Ejercicio 2============");

            Pato pato = new Pato();
            Boing747 boing747 = new Boing747();
            Superman superman = new Superman();

            TorreDeControl torreDeControl = new TorreDeControl();
            torreDeControl.agregarVolador(pato);
            torreDeControl.agregarVolador(boing747);
            torreDeControl.agregarVolador(superman);

            torreDeControl.vuelenTodos();

            Console.Write("Pulse una tecla si desea salir...");
            Console.ReadKey();
        }
    }
}
