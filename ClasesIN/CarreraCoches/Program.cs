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
<<<<<<< HEAD

            ferrari.PonerGasolina();

            ferrari.Arrancar();
            mcLaren.Arrancar();

            ferrari.Acelerar(50);
            mcLaren.Acelerar(60);

            ferrari.Frenar(30);
            mcLaren.Frenar(30);


            pista1.Competir(ferrari, mcLaren);
=======
            pista1.Competir(ferrir, mcLaren);
>>>>>>> parent of 730cfde (xd)
            //presinar Enter para continuar
            Console.ReadLine();

        }
    }
}