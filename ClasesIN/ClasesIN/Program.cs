namespace ClasesIN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Punto de comienzo del programa
            // Tipo de inicializacion
            DispositivoMovil miIphone = new DispositivoMovil();
            miIphone.almacenamiento = 64;
            miIphone.ram = 16;
            miIphone.resoluAlto = 1080;
            miIphone.resoluAncho = 1920;
            miIphone.color = new Color();
            miIphone.color.rojo = 100;
            miIphone.color.verde = 20;
            miIphone.color.azul = 210;


            DispositivoMovil tabletSamsung = new DispositivoMovil();
            tabletSamsung.almacenamiento = 256;
            tabletSamsung.ram = 8;
            tabletSamsung.resoluAlto = 1080;
            tabletSamsung.resoluAncho = 1920;

        }
    }
}