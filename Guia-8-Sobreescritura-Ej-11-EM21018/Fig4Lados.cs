using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_8_Sobreescritura_Ej_11_EM21018
{
    //Fig4Lad es figura de 4 lados, seria un cuadrado o un rectangulo
    class Fig4Lados:Figura
    {
        //clase hija con sobre escritura
        public double Area(double L1, double L2)
        {
            return (L1*L2);
        }
        public double Area(double L1)
        {
            return (L1*L1);
        }
    }
}
