using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System;

class CuentaBancaria
{
    private int Pin;
    private int Saldo;

    public void SetPin(int pin)
    {
        Pin = pin;
    }

    public void GetSaldo(int saldo)
    {
        if (Pin != 0)
        {
            Saldo = saldo;
        }
        else
        {
            Console.WriteLine("Debes establecer un PIN primero.");
        }
    }

    public int SetPin()
    {
        return Pin;
    }

    public int GetSaldo()
    {
        if (Pin != 0)
        {
            return Saldo;
        }
        else
        {
            Console.WriteLine("Debes establecer un PIN primero.");
            return 0;
        }
    }
}


