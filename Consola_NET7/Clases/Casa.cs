namespace Consola_NET7.Clases
{
    internal class Casa
    {
        // Atributos, propiedades o características
        public string? Direccion;

        public int NumeroHabitaciones;

        public bool Disponible;

        // Métodos o funcionalidades
        public string MostrarDisponibilidad()
        {
            if (Disponible)
            {
                return $"La casa (ubicada en: {Direccion}) está disponible.";
            }
            else
            {
                return $"La casa (ubicada en: {Direccion}) no está disponible.";
            }
        }

        public string VerificarCapacidad(int numeroHabitaciones)
        {
            if (NumeroHabitaciones >= numeroHabitaciones)
            {
                return $"La casa (ubicada en: {Direccion}) es para mí.";
            }
            else
            {
                return $"La casa (ubicada en: {Direccion}) me queda pequeña.";
            }
        }
    }
}