using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerHoyMiercoles
{
    internal class VehiculoFurgoneta : Vehiculo
    {

        public int Carga { set; get; }

        public VehiculoFurgoneta(string modelo, string marca, string matricula, int carga) :base(modelo, marca, matricula) {
            Carga = carga;
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine("===========VIHICULO FURGONETA=============");
            Console.WriteLine("");
            base.MostrarDetalles();
            Console.WriteLine($"Carga: {Carga}");
        }
    }
}
