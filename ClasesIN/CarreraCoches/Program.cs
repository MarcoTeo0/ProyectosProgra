namespace CarreraCoches
{
     class Program
    {
        static void Main(string[] args)
        {
            Auto ferrari = new Auto();
            ferrari.modelo = "Ferrari F1";
            ferrari.velodidad = 120;

            Auto mcLaren = new Auto();
            mcLaren.modelo = "MC 2443";
            mcLaren.velodidad = 140;

            PistaCarreras pista1 = new PistaCarreras();
            pista1.nombre = "Hermanos Rodriguez";
                pista1.longitud = 4.303f;



            ferrari.PonerGasolina();
            ferrari.Arrancar();
            mcLaren.Arrancar();



            pista1.Competir(ferrari, mcLaren);
            //presinar Enter para continuar
            Console.ReadLine();

        }
    }
}