using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaGrupal
{
    internal class Operaciones
    {
        //Jenny
        public void Suma()
        {
            double resultado= numeroPrimero+ numeroSegundo;
            Console.WriteLine("El resultado de la suma es:"+resultado);
           
        }



        //Geo


        //Henry
        public void Potencia()
        {
            double resultado = Math.Pow(numeroPrimero, numeroSegundo);
            Console.WriteLine("EL RESULTADO DE LA POTENCIA ES: [ " + resultado +" ]");
        }
        public void Radical()
        {
            double resultado = Math.Sqrt(numeroPrimero);
            Console.WriteLine("EL RESULTADO DE LA RAIZ CUBICA ES: [ " + resultado + " ]");
        }


    }
}
