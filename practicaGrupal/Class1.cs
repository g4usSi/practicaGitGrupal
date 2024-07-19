using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaGrupal
{
    internal class Operaciones
    {
        double numeroPrimero { get; set; }
        double numeroSegundo { get; set; }
// METODO ALTERADO ----------------------------------------------------------------------------------
        public void Pedir()
        {
            bool condicion = true;
            while(condicion){

                double numeroIntroducido1 = 0, numeroIntroducido2 = 0;
                    do
                    {
                    Console.Write("> Introduzca el primer numero: ");
                        try
                        {
                            numeroIntroducido1 = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("ERROR INESPERADO, VERIFIQUE LA ENTRADA... \n" + ex);
                            Console.WriteLine();
                        }

                    Console.Write("> Introduzca el segundo numero: ");
                        try
                        {
                            numeroIntroducido2 = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("ERROR INESPERADO, VERIFIQUE LA ENTRADA... \n" + ex);
                            Console.WriteLine();
                        }
                    if ((numeroIntroducido1 > 0) && (numeroIntroducido2 > 0))
                    {
                       condicion = false;
                    }
                    } while ((numeroIntroducido1 <= 0) && (numeroIntroducido2 <= 0));
                
                numeroPrimero = numeroIntroducido1;
                numeroSegundo = numeroIntroducido2;
            }
            Console.WriteLine();
        }
//HASTA ACA -------------------------------------------------------------------------------------------------
//Jenny
public void Suma()
{
    double resultado= numeroPrimero+ numeroSegundo;
    Console.WriteLine("El resultado de la suma es: "+resultado);
   
}
public void Resta()
{
    double resultado = numeroPrimero - numeroSegundo;
    Console.WriteLine("El resultado de la resta es: " + resultado);

}

        //Geo
        public void Multiplicacion()
        {
            double resultado = numeroPrimero * numeroSegundo;
            Console.WriteLine("El resultado de la multiplicacion es: "+resultado);
        }
        public void Division()
        {
            double resultado = numeroPrimero / numeroSegundo;
            Console.WriteLine("El resultado de la division es: "+resultado);
        }

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
