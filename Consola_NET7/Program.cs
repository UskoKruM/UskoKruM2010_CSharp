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

using System.Text;

string miFrase = "C#";
miFrase += " es un gran lenguaje de programación.";
Console.WriteLine(miFrase);

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
*/

/*
StringBuilder miStringBuilder = new();
int contador2 = 0;
while (contador2 < 10000)
{
    miStringBuilder.Append('X');
    contador2++;
}

Console.WriteLine(miStringBuilder.ToString());
*/

StringBuilder miStringBuilder2 = new(5000);
miStringBuilder2.Append("Ok");
string miString = miStringBuilder2.ToString();
Console.WriteLine(miString);