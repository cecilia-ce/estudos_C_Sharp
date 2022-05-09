using System;
namespace EstudosPOO
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return (Math.Pow(Altura, 2.0)) + (Math.Pow(Largura, 2.0));
        }
    }
}
