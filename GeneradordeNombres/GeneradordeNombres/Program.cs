  
 class Program
{
    static void Main()
    {
        Console.WriteLine("Generación de Nombres:");

        // Llamar al método "GenerarNombres" con los siguientes argumentos:
        // - 3 nombres completos
        // - 3 nombres aleatorios
        GenerarNombres(3, 3);

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }

    static void GenerarNombres(int nombresCompletos, int nombresAleatorios)
    {
        // Generar y mostrar "nombresCompletos" nombres completos
        for (int i = 0; i < nombresCompletos; i++)
        {
            string nombreCompleto = GeneradorDeNombres.GenerarNombreCompleto();
            Console.WriteLine("Nombre completo: " + nombreCompleto);
        }

        // Generar y mostrar "nombresAleatorios" nombres aleatorios
        for (int i = 0; i < nombresAleatorios; i++)
        {
            string nombreAleatorio = GeneradorDeNombres.GenerarNombreAleatorio();
            Console.WriteLine("Nombre aleatorio: " + nombreAleatorio);
        }
    }
}