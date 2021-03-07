using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace par_e_impar_uwu
{
    class numerospi
    {
        int numero1;
        int respuesta;


        public void numeros()
        {

            Console.WriteLine("Numeros par e impar. ");
            Console.WriteLine(" ");

            Console.WriteLine("Escribe un numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            respuesta = numero1 % 2;

            if (respuesta == 0)
            {
                Console.WriteLine("El numero {0} es par", numero1);


            }

            else

                Console.WriteLine("El numero {0} es impar", numero1);



        }

    }
}
