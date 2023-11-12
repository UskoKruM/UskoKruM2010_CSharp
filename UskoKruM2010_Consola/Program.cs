namespace UskoKruM2010_Consola
{
    using System;

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

            /*
            double sueldo;
            Console.WriteLine("Ingrese sueldo: ");
            sueldo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(sueldo);
            */

            // -----------------------------------------------------------------
            // 20. Funciones typeof, nameof y Operador de Coalescencia
            // -----------------------------------------------------------------

            // typeof
            /*
            Console.WriteLine(typeof(String));
            Console.WriteLine(typeof(int));
            Console.WriteLine(typeof(double));
            Console.WriteLine(typeof(bool));
            */

            // nameof
            /*
            int edadPersona = 21;
            Console.WriteLine(nameof(edadPersona));
            String nombreVariable = nameof(edadPersona);
            Console.WriteLine(nombreVariable);
            */

            // Operador de coalescencia
            // NULL: Ausencia de un valor.
            /*
            String d = "UskoKruM2010";
            Console.WriteLine((d == null) ? "NULL" : "No es nulo");

            if (d == null) {
                Console.WriteLine("El string indicado es: no provisto");
            } else {
                Console.WriteLine("El string especificado es: " + d);
            }

            // Si el valor del primer operando es nulo (NULL), entonces el operador 
            // devuelve el valor del segundo operando; de lo contrario, devuelve el 
            // valor del primer operando.

            Console.WriteLine("El string indicado es: " + (d ?? "no provisto"));

            double? num1 = null;
            double? num2 = 5.891;
            double num3;

            num3 = num1 ?? 25.61;
            Console.WriteLine(num3);

            num3 = num2 ?? 10.51;
            Console.WriteLine(num3);
            */

            // -----------------------------------------------------------------
            // 21. Literales de cadenas textuales (Verbatim Strings Literals)
            // -----------------------------------------------------------------

            /*
            String texto = $@"Párrafo de varias líneas: 1 - 2 - {10 - 3} 
                Esta es una nueva línea 
                Y esta es otra :)";
            Console.WriteLine(texto);

            // "No estoy de acuerdo", ella mencionó.
            String texto2 = @"""No estoy de acuerdo"", ella mencionó.";
            Console.WriteLine(texto2);

            // String nombreArchivo = "C:\temp\nuevo_archivo.txt";
            String nombreArchivo = @"C:\temp\nuevo_archivo.txt";
            Console.WriteLine(nombreArchivo);

            var multiLinea = @"Este es 
un 
párrafo!";
            Console.WriteLine(multiLinea);
            */

            // -----------------------------------------------------------------
            // 22. Bucle While
            // -----------------------------------------------------------------

            /*
            int a = 3;
            while (a < 10) {
                Console.WriteLine("Valor actual: {0}", a);
                a++;
            }

            int b = 20;
            while (b >= 5) {
                Console.WriteLine("Valor actual: {0}", b);
                b-=3;
            }
            Console.WriteLine("El bucle ha terminado.");
            */

            // -----------------------------------------------------------------
            // 23. Bucle Do While
            // -----------------------------------------------------------------

            /*
            int x = 20;
            do {
                Console.WriteLine("Valor actual: {0}", x);
            } while (x < 10);

            double estatura, alturaMaxima = 1.75;
            do {
                Console.WriteLine("Ingrese su estatura: ");
                estatura = Convert.ToDouble(Console.ReadLine());
                if (estatura > alturaMaxima) {
                    Console.WriteLine("Altura máxima: {0} metros.", alturaMaxima);
                }
            } while (estatura > alturaMaxima);

            double nota;
            do {
                Console.WriteLine("Ingrese un nota: ");
                nota = Convert.ToDouble(Console.ReadLine());
                if (nota < 0 || nota > 20) {
                    Console.WriteLine("Nota fuera rango...");
                }
            } while (nota < 0 || nota > 20);
            */

            // -----------------------------------------------------------------
            // 24. Bucle For
            // -----------------------------------------------------------------

            /*
            for(int x = 1; x <= 10; x++) {
                Console.WriteLine(x);
            }
            */

            /*
            for(int a = 100; a >= 20; a -= 3) {
                Console.WriteLine("Valor actual: {0}", a);
            }
            */

            /*
            for(int p = 1; p <= 5; p++) {
                Console.WriteLine("Ingrese valor {0}", p);
                int valor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Valor ingresado: {0}", valor);
            }
            */

            /*
            for(; ; ) {
                Console.WriteLine("Holaaaa");
            }
            */

            // -----------------------------------------------------------------
            // 25. Break - Continue
            // -----------------------------------------------------------------

            // Break:
            /*
            for(int a = 16; a <= 35; a++) {
                Console.WriteLine("Valor actual: {0}", a);
                if ((a % 7) == 0) {
                    Console.WriteLine("{0} es el primer múltiplo de 7 encontrado!",a);
                    break; // Termina el bucle.
                }
            }
            */

            // Continue:
            /*
            int contador = 0;

            do {
                if ((contador % 5) == 0) {
                    contador++;
                    continue; // Salta la iteración.
                }
                Console.WriteLine("Valor: {0}", contador);
                contador++;
            } while (contador <= 30);
            */

            // -----------------------------------------------------------------
            // 26. Vectores Unidimensionales
            // -----------------------------------------------------------------

            /*
            // int edad1, edad2, edad3, edad4, edad5;
            // int[] edades; // Vector de enteros (declaración).
            int[] edades = new int[5];
            edades[1] = 35;
            edades[2] = 21;
            Console.WriteLine(edades[2]);
            // Console.WriteLine(edades[9]);

            double[] sueldos = new double[3] { 620.50, 456.91, 190.91 };
            Console.WriteLine(sueldos);

            for(int x = 0; x < sueldos.Length; x++) {
                Console.WriteLine(sueldos[x]);
            }

            String[] lenguajes = new String[4] { "PHP", "Python", "C#", "JavaScript" };
            Console.WriteLine(lenguajes[3]);
            lenguajes[3] = "Kotlin";
            Console.WriteLine(lenguajes[3]);

            var vector = new[] { 1, 5, 19 };
            Console.WriteLine(vector[1]);
            */

            // -----------------------------------------------------------------
            // 27. Vectores Paralelos
            // -----------------------------------------------------------------

            int numeroElementos = 3;
            String[] nombres = new String[numeroElementos];
            // Variables auxiliares para leer la edad y la estatura:
            String edad = "", estatura = "";
            int[] edades = new int[numeroElementos];
            double[] estaturas = new double[numeroElementos];

            for (int a = 0; a < numeroElementos; a++)
            {
                do
                {
                    Console.WriteLine("Ingrese nombre {0}:", (a + 1));
                    nombres[a] = Console.ReadLine();
                    if (nombres[a].Length == 0)
                    {
                        Console.WriteLine("El nombre no puede estar vacío...");
                    }
                } while (nombres[a].Length == 0);

                do
                {
                    Console.WriteLine("Ingrese edad {0}:", (a + 1));
                    edad = Console.ReadLine();
                } while (int.TryParse(edad, out edades[a]));
                // int.TryParse: Intenta convertir un String a entero.
                // Si puede hacerlo, lo asignará en 'edades[a]'.

                do
                {
                    Console.WriteLine("Ingrese estatura {0}:", (a + 1));
                    estatura = Console.ReadLine();
                } while (double.TryParse(estatura, out estaturas[a]));
            }

            for (int u = 0; u < numeroElementos; u++)
            {
                Console.WriteLine("Nombre: {0} | Edad: {1} años | Estatura: {2} mts.",
                    nombres[u], edades[u], estaturas[u]);
            }
        }
    }
}