﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaGrupal
{
    internal class Operaciones
    { 
        double numeroPrimero {  get; set; }
        double numeroSegundo { get; set; }

        public void Pedir()

        {
            double numeroIntroducido1 = 0,  numeroIntroducido2=0;
            do
            {
                Console.WriteLine("Introduzca el primer numero: ");
               numeroIntroducido1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduzca el segundo numero: ");
                numeroIntroducido2 = Convert.ToInt32(Console.ReadLine());
                if ((numeroIntroducido1 < 0) && (numeroIntroducido2 < 0))
                {
                    Console.WriteLine("No puede ingresar numeros negativos...");
                }
            } while ((numeroIntroducido1 < 0) && (numeroIntroducido2 < 0));

            numeroPrimero = numeroIntroducido1;
            numeroSegundo = numeroIntroducido2;
        }
        //Jenny
        public void Suma()
        {
            double resultado= numeroPrimero+ numeroSegundo;
            Console.WriteLine("El resultado de la suma es:"+resultado);
           
        }
        public void Resta()
        {
            double resultado = numeroPrimero - numeroSegundo;
            Console.WriteLine("El resultado de la resta es:" + resultado);

        }



        //Geo


        //Henry



    }
}
