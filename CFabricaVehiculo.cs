using System;
using System.Collections.Generic;
using System.Text;

namespace TAREA2
{
    class CFabricaVehiculo
    {
        public static IRentado GetRentar(int valor)
        {
            if ( valor == 1)
            {
                return new CGruas();
            }
            if (valor == 2)
            {
                return new CTrator();
            }
            if (valor == 3)
            {
                return new CRestroexcavadora();
            }
            else
            {
                return new CEscalera_Hidraulica();
            }
          

        }

    }
}
