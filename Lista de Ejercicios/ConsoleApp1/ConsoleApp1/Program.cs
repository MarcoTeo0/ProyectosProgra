class Program
{
    static void Main(string[] args)
    {
        CuentaBancaria cuenta = new CuentaBancaria();
        cuenta.EstablecerPin(1234); // Establecer un PIN
        cuenta.EstablecerSaldo(10000); // Establecer el saldo

        // Obtener el PIN y el saldo
        Console.WriteLine("PIN: " + cuenta.ObtenerPin());
        Console.WriteLine("Saldo: " + cuenta.ObtenerSaldo());

        // Intentar obtener el saldo sin establecer un PIN
        CuentaBancaria cuenta2 = new CuentaBancaria();
        Console.WriteLine("Saldo sin PIN: " + cuenta2.ObtenerSaldo()); // Mostrará un mensaje de que se debe establecer un PIN primero
    }
}

