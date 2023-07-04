using System;
using System.Collections.Generic;
using System.Text;

namespace TAREA2
{
    abstract class IRentar 
    {
        protected CVehiculo vehiculo;

        

        public CVehiculo Vehiculo { get => vehiculo; set => vehiculo = value; }

        public IRentar(CVehiculo pvehiculo)
        {
            vehiculo = pvehiculo;
        }

        public override string ToString()
        {
            return vehiculo.ToString();
        }




        public abstract string Marca();

        public abstract double Precio();


        //public void  Rentar()
        //{
        //    Console.WriteLine("Ingrese la marca");
        //    vehiculo.Marca = Console.ReadLine();

        //    Console.WriteLine("Ingrese la marca");
        //    vehiculo.Precio = double.Parse(Console.ReadLine());

        //}
    }
}
