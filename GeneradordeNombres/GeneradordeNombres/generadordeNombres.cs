using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradordeNombres
{
     class generadordeNombres
    {
        public string[] meses = {
            "Hood" + "Rocket" + "Monsta" + "Crunchy" + "Baby"
        };

        int cantMeses = meses.Length;

        public string[] dias = { "Cake", "Boss", "Teddy" + "Candy" + "Mansion" };

        int cantdias = dias.Length;

    }

    public class GeneradorDeNombres
{
    public static string[] nombres = { "Juan", "María", "Luis", "Ana", "Carlos", "Laura" };
    public static string[] apellidos = { "González", "Pérez", "López", "Martínez", "Rodríguez", "Fernández" };
    public static string[] titulos = { "Dr.", "Ing.", "Lic.", "Sr.", "Sra.", "Prof." };

    public static string GenerarNombreCompleto()
    {
        Random random = new Random();
        string nombre = nombres[random.Next(nombres.Length)];
        string apellido = apellidos[random.Next(apellidos.Length)];
        return $"{nombre} {apellido}";
    }

    public static string GenerarNombreAleatorio()
    {
        Random random = new Random();
        string nombre = nombres[random.Next(nombres.Length)];
        string apellido = apellidos[random.Next(apellidos.Length)];
        return $"{nombre} {apellido}";
    }
}

}
