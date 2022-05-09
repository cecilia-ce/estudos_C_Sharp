using System;
using System.Collections.Generic;
using System.Text;

namespace EstudosPOO
{
    class Calculadora
    {
        public static double Pi = 3.14;

        public static double Circunferencia(double raiz)
        {
            return 2.0 * Pi * raiz;
        }

        public static double Volume(double raiz)
        {
            return 4.0 / 3.0 * Pi * raiz * raiz * raiz;
        }
    }
}
