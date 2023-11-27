using Consola_NET7.Clases;
using System.Text;

// -----------------------------------------------------------------
// 31. Métodos de Cadenas [01]
// -----------------------------------------------------------------

/*
string texto = "Frase de prueba";

Console.WriteLine(texto.Length);
Console.WriteLine(" C Sharp ".Length);
Console.WriteLine(" C Sharp ".Trim().Length);
Console.WriteLine("Alex".CompareTo("Andres"));
Console.WriteLine("Andres".CompareTo("Alex"));
Console.WriteLine(texto.Contains('u'));

Console.WriteLine("UskoKruM2010".Equals("uskokrum2010"));
Console.WriteLine("UskoKruM2010".Equals("uskokrum2010", StringComparison.InvariantCultureIgnoreCase));

// -----------------------------------------------------------------
// 32. Métodos de Cadenas [02]
// -----------------------------------------------------------------

Console.WriteLine(texto.GetType());
Console.WriteLine(texto.GetType().Name);

Console.WriteLine(texto.IndexOf("p"));
Console.WriteLine(texto.LastIndexOf("e"));

Console.WriteLine(texto.Insert(4, texto));
string texto2 = texto.Insert(4, texto);
Console.WriteLine(texto2);

Console.WriteLine(texto.Remove(3, 4));
Console.WriteLine(texto.Replace('e', 'x'));
Console.WriteLine(texto.StartsWith('f'));
Console.WriteLine(texto.EndsWith('.'));

Console.WriteLine(texto.PadLeft(100, '*'));
Console.WriteLine(texto.PadRight(100, '*'));

Console.WriteLine(texto.Substring(3));
Console.WriteLine(texto.Substring(3, 5));

Console.WriteLine(texto.ToLower());
Console.WriteLine(texto.ToUpper());

string[] palabras = texto.Split(' ');
for (int i = 0; i < palabras.Length; i++)
{
    Console.WriteLine($"{i}: {palabras[i]}");
}
*/

// -----------------------------------------------------------------
// 33. StringBuilder
// -----------------------------------------------------------------

/*
string miFrase = "C#";
miFrase += " es un gran lenguaje de programación.";
Console.WriteLine(miFrase);
*/

/*
    - 1. Se crea una nueva colección de caracteres con longitud igual
    al String original + la longitud del nuevo String que anexamos.
    - 2. Se copian los caracteres del String original al inicio de la nueva 
    colección de caracteres y, a continuación, los caracteres del nuevo 
    String.
    - 3. Se crea un nuevo objeto de tipo String en memoria y se reasigna en
    a: 'miFrase'.
*/

/*
int contador = 0;
while (contador < 10000)
{
    miFrase += "X";
    contador++;
}

StringBuilder miStringBuilder = new();
int contador2 = 0;
while (contador2 < 10000)
{
    miStringBuilder.Append('X');
    contador2++;
}

Console.WriteLine(miStringBuilder.ToString());

StringBuilder miStringBuilder2 = new(5000);
miStringBuilder2.Append("Ok");
string miString = miStringBuilder2.ToString();
Console.WriteLine(miString);

*/

// -----------------------------------------------------------------
// 34. POO (Programación Orientada a Objetos) [01]
// -----------------------------------------------------------------

/*
Casa casa1; // Instancia, objeto o ejemplar de la clase 'Casa'.

casa1 = new(); // Inicialización del objeto 'casa1'.

casa1.Direccion = "Los Pinos 123";

Casa casa2 = new();

casa2.Direccion = "La Florida 192";

Console.WriteLine(casa1);
Console.WriteLine(casa1.Direccion);
Console.WriteLine(casa2.Direccion);
*/

// -----------------------------------------------------------------
// 35. POO (Programación Orientada a Objetos) [02]
// -----------------------------------------------------------------

/*
Casa casa1 = new()
{
    Direccion = "Los Pinos 123",
    NumeroHabitaciones = 4,
    Disponible = true
};

Casa casa2 = new()
{
    Direccion = "La Florida 934",
    NumeroHabitaciones = 3,
    Disponible = false
};

Console.WriteLine(casa1.MostrarDisponibilidad());
Console.WriteLine(casa2.MostrarDisponibilidad());

Console.WriteLine(casa1.VerificarCapacidad(6));
Console.WriteLine(casa2.VerificarCapacidad(1));

casa2.Disponible = true;

Console.WriteLine(casa2.MostrarDisponibilidad());
*/

// -----------------------------------------------------------------
// 36. POO (Programación Orientada a Objetos) [03] Constructores
// -----------------------------------------------------------------

/*
Programador programador1 = new("UskoKruM2010", 31);
Programador programador2 = new("PildorasInformaticas", 38);

Console.WriteLine(programador1.MostrarDatos());
Console.WriteLine(programador2.MostrarDatos());

Console.WriteLine(programador1.Nombre + " | " + programador1.Edad);
Console.WriteLine(programador2.Nombre + " | " + programador2.Edad);

Console.WriteLine(programador1.Lenguajes);
Console.WriteLine(programador2.Lenguajes);
*/

// -----------------------------------------------------------------
// 37. POO (Programación Orientada a Objetos) [04] Encapsulamiento
// -----------------------------------------------------------------

Programador programador1 = new("UskoKruM2010", 31);
Programador programador2 = new("PildorasInformaticas", 38);