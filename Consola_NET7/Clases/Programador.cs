namespace Consola_NET7.Clases
{
    internal class Programador
    {
        // Propiedades
        public string? Nombre;

        public int Edad;

        public string[]? Lenguajes;

        // Constructor
        public Programador(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
            Lenguajes = new string[10];
        }

        public string MostrarDatos()
        {
            return $"El programador '{Nombre}' tiene {Edad} años.";
        }
    }
}