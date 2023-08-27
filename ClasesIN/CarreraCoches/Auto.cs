using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarreraCoches
{
    public class Auto
    {
        public string modelo;
        public Color color;
        public float velodidad;
        public float gasolina;


        public void Arrancar()
        {
            if (gasolina > 0) //si tiene gas
            {
                gasolina = gasolina - 0.1f;
                Console.WriteLine("Arrancando" + modelo + ", le queda" + gasolina + "1 de gas");

            }
            else //no tieneg gas
            {
                Console.WriteLine(modelo + "no tiene gas. No se puede arrancar.");
            }

            public void PonerGasolina(float cantidad)
            {
                gasolina = gasolina + cantidad;
                Console.WriteLine("se puso gasolina a" + modelo + ".Ahora tiene" + gasolina + "1.");
                    
            }
        }
        private int velocidadActual = 0;  //almacena la velocidad del auto, es privada
        public void Acelerar (int velocidad) //metodo publico que recibe la velocidad y la aumenta a la velocidad Actual
                                             //para luego mostrarla
        {
            velocidadActual += velocidad;
            Console.WriteLine("Acelerando a" + modelo + velocidadActual + "km/h.");

        }
        public void Frenar (int cantidad) //recibe un argumento cantidad y reduce la velocidad actual
        {
            velocidadActual -= cantidad; //si la velocidad se vuelve negativa,
                                         //se establece en 0
                                         //se resta 30 a la velocidadActual. se resta cantidad de velocidadActual 
                                         //se actualiza el valor de velocidadActual

            if
                (velocidadActual < 0) //verifica que sea menor que 0
            {
                velocidadActual = 0;//asegurarse de que la velocidad no sea negativa
                
            }

            Console.WriteLine("Reduciendo velocidad de" + modelo + "a" + velocidadActual + "km/h."
                );

            if (velocidadActual == 0)// Luego muestra un mensaje en la consola indicando la velocidad actual y,
                                     // si la velocidad es 0,
                                     // muestra un mensaje adicional indicando que el auto se ha detenido.
            {
                Console.WriteLine("El auto" + modelo + "se ha detenido completamente");

            }
        }
       
    }
}
