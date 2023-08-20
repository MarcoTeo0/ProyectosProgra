namespace CarreraCoches
{
     class Program
    {
        static void Main(string[] args)
        {
            Coche ferrari = new Coche();
            ferrari.modelo = "Ferrari F1";
            ferrari.velodidad = 120;

            Coche mcLaren = new Coche();
            mcLaren.modelo = "MC 2443"
            mcLaren.velodidad = 140;

            PistaCarreras pista1 = new PistaCarreras();
            pista1.nombre = "Hermanos Rodriguez"
                pista1.longitud = 4.303f;
            pista1.Competir(ferrir, mcLaren);
            //presinar Enter para continuar
            Console.ReadLine();

        }
    }
}