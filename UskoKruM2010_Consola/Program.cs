using System;

namespace UskoKruM2010_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hola Mundo!");
            // Aquí voy a imprimir el nombre de mi canal:
            /*
            Console.WriteLine("UskoKruM2010");

            Console.WriteLine("aaa");
            Console.WriteLine("bbb");
            Console.WriteLine("ccc");

            Console.WriteLine("Suscríbete!");
            */
            /*
            int edad; // Declarando una variable.
            edad = 31; // Asignando un valor a la variable.
            Console.WriteLine(edad);

            // double sueldo = 1700.50; // Declarando e inicializando una variable.
            // float sueldo = 1700.50f; // Declarando e inicializando una variable.
            decimal sueldo = 1700.50782348234M; // Declarando e inicializando una variable.
            Console.WriteLine(sueldo);

            long valorGrande = 8394832948392849332;
            Console.WriteLine(valorGrande);

            short edad2 = 16;
            Console.WriteLine(edad2);
            */

            /*
             * Enteros con signo:
             * - sbyte: 0 a 255
             * - short
             * - int (32 bits)
             * - long (64 bits)
             * 
             * Enteros que pueden ser negativos o positivos:
             * - byte: -127 a 128
             * - ushort
             * - uint
             * - ulong
             */

            /*
            char letra = 'K';
            Console.WriteLine(letra);

            String nombreCanal = "UskoKruM2010";
            Console.WriteLine(nombreCanal);

            bool esMayorDeEdad = false; // false / true
            Console.WriteLine(esMayorDeEdad);
            */

            /*
            int p1, p2, p3, p4;
            p1 = p2 = p3 = p4 = 21;
            Console.WriteLine(p3);

            String a, b;
            a = b = "UskoKruM2010";
            Console.WriteLine(a);

            b = "Curso de C#";
            Console.WriteLine(b);
            */

            /*
            const String nombreCanal = "UskoKruM2010";
            Console.WriteLine(nombreCanal);

            const int edadActual = 28;
            Console.WriteLine(edadActual);
            */

            /*
            var peso = 85;
            Console.WriteLine(peso);

            // peso = "92";

            dynamic nombre = "Oscar";
            Console.WriteLine(nombre);

            nombre = 25;
            Console.WriteLine(nombre);

            nombre = 'O';
            Console.WriteLine(nombre);
            */

            // Implítica: Entre tipos de datos compatibles, de diferente alcance.

            /*
            sbyte a = 15;
            short c = a;
            Console.WriteLine(c);
            */

            // Explícita: De forma directa e intencional.

            /*
            int a = 123;
            sbyte x = (sbyte)a;
            Console.WriteLine(x);

            String num = "678";
            int miNumero = int.Parse(num);
            Console.WriteLine(miNumero);

            String u = "56";
            // double miDouble = double.Parse(u);
            double miDouble = Convert.ToDouble(u);
            Console.WriteLine(miDouble);
            */

            // Operadores matemáticos:

            // +, -, *, /, %
            // int numero1 = 17,numero2=4;
            /*
            Console.WriteLine(17.0 + 4.0);
            Console.WriteLine(17.0 - 4.0);
            Console.WriteLine(17.0 * 4.0);
            Console.WriteLine(17 / 4.0);
            Console.WriteLine(17.0 % 4.0);
            */
            /*
            Console.WriteLine(numero1 + numero2);
            Console.WriteLine(numero1 - numero2);
            Console.WriteLine(numero1 * numero2);
            Console.WriteLine(numero1 / numero2);
            Console.WriteLine(numero1 % numero2);
            */

            // Incremento y Decremento:

            /*
            int x = 41;
            x++; // x = x + 1 => Postincremento
            Console.WriteLine(x);

            x--; // x = x - 1 => Postdecremento
            Console.WriteLine(x);

            int t = 110;
            Console.WriteLine(t++);
            Console.WriteLine(t);

            int p = 215;
            Console.WriteLine(++p); // Preincremento.
            Console.WriteLine(p);

            int m = 450;
            Console.WriteLine(--m); // Predecremento.
            Console.WriteLine(++m);
            */

            // Operadores Lógicos:

            // bool a = true, b = false;

            /*
            int numero = 21;
            // AND
            Console.WriteLine(a && (numero>5));
            Console.WriteLine(a && b);
            Console.WriteLine(b && a);
            Console.WriteLine(b && b);
            */

            // OR
            /*
            Console.WriteLine(a || a);
            Console.WriteLine(a || b);
            Console.WriteLine(b || a);
            Console.WriteLine(b || b);
            */

            // NOT
            // Console.WriteLine(!a);
            // Console.WriteLine(!b);

            // Exclusive OR
            /*
            Console.WriteLine(a ^ b);
            Console.WriteLine(b ^ a);
            Console.WriteLine(b ^ b);
            Console.WriteLine(a ^ a);
            */

            // Operadores comparativos:

            /*
            int n1=12, n2=12;

            Console.WriteLine(n1 > n2); // Mayor que
            Console.WriteLine(n1 < n2); // Menor que
            Console.WriteLine(n1 >= n2); // Mayor o igual que
            Console.WriteLine(n1 <= n2); // Menor o igual que
            Console.WriteLine(n1 == n2); // Igualdad
            Console.WriteLine(n1 != n2); // Diferencia

            char le1 = 'a', le2 = 'b';
            Console.WriteLine(le1 == le2);

            String numero = "123";
            int num = 123;
            Console.WriteLine(numero.Equals(num));
            */

            // Operador ternario:

            /*
            int edad = 14;
            Console.WriteLine(edad >= 18 ? "Es mayor de edad" : "Es menor de edad");

            char sexo = 'F';
            String texto = ((sexo == 'M') ? "Masculino" : "Femenino");
            Console.WriteLine(texto);
            */

        }
    }
}