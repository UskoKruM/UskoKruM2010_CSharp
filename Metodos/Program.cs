using System;

namespace Metodos
{
    class Program
    {

        static void Saludar()
        {
            Console.WriteLine("Hola! Estoy siendo llamado desde un método!");
        }

        static void Despedir(string Nombre)
        {
            Console.WriteLine($"Fue un gusto verte, {Nombre}");
        }

        static void Sumar(int Numero1, int Numero2)
        {
            Console.WriteLine($"La suma de {Numero1} + {Numero2} es: {(Numero1 + Numero2)}");
        }

        static int Multiplicar(int Numero1, int Numero2)
        {
            return 1;
        }

        static double Dividir(double Dividendo, double Divisor, double Factor = 1)
        {
            return (Dividendo / Divisor) * Factor;
        }

        static double Dividir2(double Dividendo, double Divisor) => Dividendo / Divisor;

        static int Restar(int Num1, int Num2) => Num1 - Num2;
        static int Restar(int Num1, int Num2, int Num3) => Num1 - Num2 - Num3;
        static int Restar(int Num1, int Num2, int Num3, int Num4) => Num1 - Num2 - Num3 - Num4;

        static void Main(string[] args)
        {
            Console.WriteLine(Restar(20, 10));
            Console.WriteLine(Restar(20, 10, 5));
            Console.WriteLine(Restar(50, 10, 15));
            /*
            int producto = Multiplicar(5, 8);
            Console.WriteLine(producto);
            Console.WriteLine(Dividir(25, 5));
            Console.WriteLine(Dividir(25, 5, 100));
            Console.WriteLine(Dividir2(45, 15));
            Saludar();
            Saludar();
            Saludar();
            Console.WriteLine("Hello World! 123");
            Saludar();
            Sumar(15, 20);
            Despedir("Oscar");
            Despedir("Karen");
            */

        }
    }
}