using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerHoyMiercoles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo Vehiculo = new Vehiculo("MED-3245", "Chevrolet", "2025");
            Vehiculo.MostrarDetalles();

            VehiculoDeportivo  VehiculoDeportivo = new VehiculoDeportivo("AMT-4532", "BMW", "2024", 10000);
            VehiculoDeportivo.MostrarDetalles();

            VehiculoFurgoneta VehiculoFurgoneta = new VehiculoFurgoneta("HJL-2134", "Lenovo", "2019", 3000);
            VehiculoFurgoneta.MostrarDetalles();

            VehiculoTurismo VehiculoTurismo = new VehiculoTurismo("MJK-2468", "Chevolet", "2023", 4);
            VehiculoTurismo.MostrarDetalles();
            Console.ResetColor();

        }
    }
}
