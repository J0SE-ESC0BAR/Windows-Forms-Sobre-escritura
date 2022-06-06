using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_8_Sobreescritura_Ej_11_EM21018
{
    //Fig3Lad es figura de 3 lados, seria un triangulo
    //clase hija con sobre escritura
    class Fig3Lad :Figura
    {

        double area = 0;
        public double Perimetro(double L1, double L2, double L3) 
        {
            double p = 0;
            p = L1 + L2 + L3;
            return p;
        }
        public double Area(double L1, double L2, double L3)
        {
            double s = 0;
            s = (Perimetro(L1, L2, L3) / 2);
            area = Math.Sqrt(s * (s - L1) * (s - L2) * (s - L3));
            return area;
        }
        public double Area(double L1, double L2)
        {
            area = (L1 * L2)/ 2;
            return area;
        }
        public double Area(double L1)
        {
            area = (Math.Sqrt(3) * L1) / 2;
            return area;
        }
    }
}
