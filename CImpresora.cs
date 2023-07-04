using System;
using System.Collections.Generic;
using System.Text;

namespace TAREA2
{
    class CImpresora
    {
       // private CVehiculo vehiculo;

        CVehiculo vehiculo = new CVehiculo();

        private static CImpresora instancia;



        public static CImpresora GetImpresora()
        {
            if (instancia == null)
            {
                instancia = new CImpresora();
            }

            return instancia;
        }
       

        public void Imprimir()
        {
            //Console.WriteLine($" Equipo Rentado {vehiculo.GetType().Name}");
            Console.WriteLine(" ");
            Console.WriteLine("************************************* Comprobante ***********************************************");
            Console.WriteLine($" Marca " + vehiculo.Marca);
            Console.WriteLine($" Precio " + vehiculo.Precio);
            Console.WriteLine("\t Fecha: " + DateTime.Today.ToString("dd-MM-yyyy"));
            Console.WriteLine("\t Hora: " + DateTime.Now.ToString("HH:mm:ss"));

        }


    }
}
