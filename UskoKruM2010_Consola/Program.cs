using System;

namespace UskoKruM2010_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------
            // 3. Creación de Primer Proyecto & Hola Mundo en Consola
            // -----------------------------------------------------------------
            // Console.WriteLine("UskoKruM2010");

            // -----------------------------------------------------------------
            // 5. Comentarios en C Sharp (Única Línea y Multilínea)
            // -----------------------------------------------------------------

            // Console.WriteLine("Hola Mundo!");
            // Aquí voy a imprimir el nombre de mi canal:
            // Console.WriteLine("UskoKruM2010");

            /*
            Console.WriteLine("aaa");
            Console.WriteLine("bbb");
            Console.WriteLine("ccc");

            Console.WriteLine("Suscríbete!");
            */

            // -----------------------------------------------------------------
            // 6. Tipos de Datos Primitivos y Declaración e Inicialización de Variables
            // -----------------------------------------------------------------

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

            // -----------------------------------------------------------------
            // 7. Inicialización Múltiple de Variables y Constantes
            // -----------------------------------------------------------------

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

            // -----------------------------------------------------------------
            // 8. VAR y DYNAMIC | Comparación y Diferencias
            // -----------------------------------------------------------------

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

            // -----------------------------------------------------------------
            // 9. Casting Conversiones Implícitas e Explícitas
            // -----------------------------------------------------------------

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

            // -----------------------------------------------------------------
            // 10. Operadores Matemáticos y Operadores de Incremento y Decremento
            // -----------------------------------------------------------------

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

            // -----------------------------------------------------------------
            // 11. Operadores Lógicos (AND %%, OR , NOT y OR Exclusivo)
            // -----------------------------------------------------------------

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

            // -----------------------------------------------------------------
            // 12. Operadores Comparativos (Comparación de Valores)
            // -----------------------------------------------------------------

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

            // -----------------------------------------------------------------
            // 13. Operador Ternario en C#
            // -----------------------------------------------------------------

            /*
            int edad = 14;
            Console.WriteLine(edad >= 18 ? "Es mayor de edad" : "Es menor de edad");

            char sexo = 'F';
            String texto = ((sexo == 'M') ? "Masculino" : "Femenino");
            Console.WriteLine(texto);
            */

            // -----------------------------------------------------------------
            // 14. Funciones default (Valor por Defecto) y sizeof (Tamaño en Bytes)
            // -----------------------------------------------------------------

            /*
            Console.WriteLine(default(int)); // 0
            Console.WriteLine(default(float)); // 0
            Console.WriteLine(default(char)); // Caracter "vacío"
            Console.WriteLine(default(double)); // 0

            Console.WriteLine(default(object)); // null
            Console.WriteLine(default(string)); // null
            Console.WriteLine(default(DateTime)); // 01/01/0001 00:00:00

            Console.WriteLine(default(string) == null); // Comparación
            */

            // sizeof: Retorna el número de bytes que ocupa cada tipo de dato.
            /*
            Console.WriteLine(sizeof(bool)); // 1
            Console.WriteLine(sizeof(byte)); // Returns 1.
            Console.WriteLine(sizeof(sbyte)); // Returns 1.
            Console.WriteLine(sizeof(char)); // Returns 2.
            Console.WriteLine(sizeof(short)); // Returns 2.
            Console.WriteLine(sizeof(ushort)); // Returns 2.
            Console.WriteLine(sizeof(int)); // Returns 4.
            Console.WriteLine(sizeof(uint)); // Returns 4.
            Console.WriteLine(sizeof(float)); // Returns 4.
            Console.WriteLine(sizeof(long)); // Returns 8.
            Console.WriteLine(sizeof(ulong)); // Returns 8.
            Console.WriteLine(sizeof(double)); // Returns 8.
            Console.WriteLine(sizeof(decimal)); // Returns 16.
            */

            // -----------------------------------------------------------------
            // 15. Clase Math Funciones Matemáticas Predefinidas
            // -----------------------------------------------------------------

            /*
            // Clase Math y sus funcionalidades:
            Console.WriteLine(Math.Max(45.12, 45.61));
            Console.WriteLine(Math.Min(45.12, 45.61));

            Console.WriteLine(Math.Pow(5, 3));

            Console.WriteLine(Math.Sqrt(17));

            Console.WriteLine(Math.PI);

            double numero = 3.0001681;
            Console.WriteLine(Math.Round(numero)); // Evalúa el redondeo.
            Console.WriteLine(Math.Ceiling(numero)); // Hacia arriba
            Console.WriteLine(Math.Floor(numero)); // Hacia abajo

            Console.WriteLine(Math.Abs(-123));
            */

            // -----------------------------------------------------------------
            // 16. Concatenación (Unión de texto y variables) en C Sharp
            // -----------------------------------------------------------------

            /*
            string texto1 = "Hola ", texto2 = "Mundo!";
            int edad = 28;
            Console.WriteLine(texto1 + texto2 + " " + edad);

            String resultado = texto1 + texto2;
            Console.WriteLine(resultado);

            String miTexto;
            miTexto = String.Concat(texto1, texto2);
            Console.WriteLine(miTexto);

            String miTexto2;
            miTexto2 = $"{texto1}{texto2}";
            Console.WriteLine(miTexto2);

            String miTexto3 = String.Format("{0}{1}", texto1, texto2);
            Console.WriteLine(miTexto3);

            Console.WriteLine("{0}{1}", texto1, texto2);
            */

            // -----------------------------------------------------------------
            // 17. Estructura decisiva IF - ELSE
            // -----------------------------------------------------------------

            /*
            int edad = 18;
            if (edad >= 18) {
                Console.WriteLine("Ya eres mayor de edad.");
            } else {
                Console.WriteLine("Aún eres menor de edad.");
                Console.WriteLine("Tienes menos de 18 años.");
            }

            char sexo = 'F';
            if (sexo == 'F') {
                Console.WriteLine("Tu sexo es: femenino.");
            } else {
                Console.WriteLine("Tu sexo es: masculino.");
            }
            */

            // -----------------------------------------------------------------
            // 18. IF - ELSE anidados
            // -----------------------------------------------------------------

            /*
            int nota = 11;
            if (nota > 11) {
                Console.WriteLine("Aprobado");
            } else if (nota == 11) {
                Console.WriteLine("Aprobaste con mucho riesgo!!!");
            } else {
                Console.WriteLine("Desaprobado");
            }
            */

            /*
            int promedio = 16;

            if (promedio >= 17) {
                Console.WriteLine("Excelente");
            } else if (promedio >= 11) {
                Console.WriteLine("Aprobado");
            } else {
                if (promedio >= 8) {
                    Console.WriteLine("Puede ir a recuperación");
                } else {
                    Console.WriteLine("Desaprobado definitivamente");
                }
            }
            */

            // -----------------------------------------------------------------
            // 19. Lectura de datos por teclado
            // -----------------------------------------------------------------

            /*
            String nombre;
            Console.WriteLine("Ingrese su nombre completo: ");
            nombre = Console.ReadLine();
            Console.WriteLine(nombre);
            Console.WriteLine("Longitud: {0}", nombre.Length);
            */

            /*
            int edad;
            Console.WriteLine("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine(edad);
            Console.WriteLine(edad + 17);
            */

            double sueldo;
            Console.WriteLine("Ingrese sueldo: ");
            sueldo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(sueldo);

        }
    }
}