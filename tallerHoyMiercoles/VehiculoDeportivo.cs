using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerHoyMiercoles
{
    internal class VehiculoDeportivo : Vehiculo
    {
        public int Cilindraje { set; get; }

        public VehiculoDeportivo(string matricula, string modelo, string marca, int cilidraje ) : base(matricula, modelo, marca) 
        {
            Cilindraje = cilidraje;
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine("===========VIHICULO DEPORTIVO=============");
            Console.WriteLine("");
            base.MostrarDetalles();
            Console.WriteLine($"Cilindraje: {Cilindraje}");
        }
    }
}
