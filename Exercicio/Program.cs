using System.Globalization;

    namespace ConsoleApp3
    {
        class Program
        {
            static void Main(string[] args)
            {
                Retangulo r;
                r = new Retangulo();

                Console.WriteLine("Entre com a altura do retângulo: ");
                r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Entre com a largura do retângulo: ");
                r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("AREA: " + r.ValorAreaRetangulo().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("PERIMETRO: " + r.ValorPerimetroRetangulo().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("DIAGONAL: " + r.ValorDiagonalRetangulo().ToString("F2", CultureInfo.InvariantCulture));
            }
        }    
    }
