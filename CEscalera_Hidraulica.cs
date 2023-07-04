using System;
using System.Collections.Generic;
using System.Text;

namespace TAREA2
{
    class CEscalera_Hidraulica : IRentado
    {
        CVehiculo vehiculo = new CVehiculo();

        public void Rentar()
        {
            Console.WriteLine("Ingrese la marca");
            vehiculo.Marca = (Console.ReadLine());

            Console.WriteLine("Ingrese el Precio a rentar ");
            vehiculo.Precio = double.Parse(Console.ReadLine());
        }
    }
}
