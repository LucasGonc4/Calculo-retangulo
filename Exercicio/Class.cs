using System;
using System.Globalization;

namespace ConsoleApp3
{
    internal class Retangulo
    {
        public double Altura;
        public double Largura;

        public double ValorPerimetroRetangulo()
        {
            return (Altura * 2) + (Largura * 2);
        }
        public double ValorDiagonalRetangulo()
        {
            return (Math.Sqrt(Altura * Altura + Largura * Largura));
        }
        public double ValorAreaRetangulo()
        {
            return Altura * Largura;
        }

    }


}
