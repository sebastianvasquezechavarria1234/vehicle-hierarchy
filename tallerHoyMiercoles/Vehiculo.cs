using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerHoyMiercoles
{
    [Serializable] // 👈 Esto indica que la clase puede ser serializada
    internal class Vehiculo
    {
        protected string Matricula { set; get; }
        protected string Marca { set; get; }
        protected string Modelo { set; get; }

        public Vehiculo(string matricula, string marca, string modelo)
        {
            Matricula = matricula;
            Marca = marca;
            Modelo = modelo;
        }

        public virtual void MostrarDetalles()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Matricula: {Matricula}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
        }

       
    }
}
