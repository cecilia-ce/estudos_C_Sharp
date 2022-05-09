using System;
using System.Collections.Generic;
using System.Text;

namespace EstudosPOO
{
    class ConversorDeMoeda
    {
        public static double Conversor(double cotDolar, double dolComp )
        {
            double valorBruto = cotDolar * dolComp;
            double valorFinal = valorBruto + (valorBruto * 0.06);
            return valorFinal; 
        }
    }
}
