using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHierarchy
{
    internal class VehiculoTurismo : Vehiculo
    {
        public int Puertas { set; get; }
        public VehiculoTurismo(string modelo, string matricula, string marca, int puertas) :base(marca, matricula, modelo)
        
        {
            Puertas = puertas;
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine("===========VIHICULO TURISMO=============");
            Console.WriteLine("");
            base.MostrarDetalles();
            Console.WriteLine($"Numero de puertas: {Puertas}");
        }




    }
}
