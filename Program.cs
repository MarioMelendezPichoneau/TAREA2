using System;

namespace TAREA2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Selecione una Maquinaria a rentar");
            Console.WriteLine(" [1] Gruas, [2] Trator, [3] Restroexcavadora, [4] Escalera Hidraulica ");
            int op = int.Parse(Console.ReadLine());

            IRentado rentar = CFabricaVehiculo.GetRentar(op);
            CImpresora imp = new CImpresora();

            switch (op)
            {
                case 1:
                    rentar.Rentar();
                    imp.Imprimir();
                    break;

                case 2:
                    rentar.Rentar();
                    imp.Imprimir();
                    break;


                case 3:
                    rentar.Rentar();
                    imp.Imprimir();
                    break;


                case 4:
                    rentar.Rentar();
                    imp.Imprimir();
                    break;


            }

            Console.ReadKey();
        }
    }
}
