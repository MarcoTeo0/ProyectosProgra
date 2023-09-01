namespace Persona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Pedro, 18, Masculino");


            Console.WriteLine("Nombre: " + persona1.GetNombre());
            Console.WriteLine("Edad: " + persona1.GetEdad());
            Console.WriteLine("Género: " + persona1.GetGenero());

            // Establecer nuevos valores de atributos
            persona1.SetNombre("Ana");
            persona1.SetEdad(25);
            persona1.SetGenero("Femenino");

            // Mostrar los nuevos valores de atributos
            Console.WriteLine("Nombre: " + persona1.GetNombre());
            Console.WriteLine("Edad: " + persona1.GetEdad());
            Console.WriteLine("Género: " + persona1.GetGenero());
        }
    }
}