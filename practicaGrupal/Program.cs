using practicaGrupal;

class Program
{
    public static void Main(String[] args) {
        Operaciones operacion = new Operaciones();
        int opcionMenu;
        do
        {
            Console.WriteLine("\nCALCULADORA");
            Console.WriteLine("A continuacion introduzca los numeros a operar [cant: 2]");
            operacion.Pedir();
            Console.WriteLine("Menu");
            Console.WriteLine("[1] Suma");
            Console.WriteLine("[2] Resta");
            Console.WriteLine("[3] Multiplicacion");
            Console.WriteLine("[4] Division");
            Console.WriteLine("[5] Potencia");
            Console.WriteLine("[6] Raiz");
            Console.WriteLine("[7] Salir");
            Console.Write("Ingrese una opcion: ");

            try
            {
                opcionMenu = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error solo puede introducir letras... \n" + ex);
                opcionMenu = 10;
                continue;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inesperado... \n" + ex);
                opcionMenu = 10;
                continue;
            }

            Console.WriteLine();
            switch (opcionMenu)
            {
                //Jenny
                case 1:
                    Console.WriteLine("[1] Suma");
                    operacion.Suma();

                    break;
                case 2:
                    Console.WriteLine("[2] Resta");
                    operacion.Resta();
                    break;
                //Geo
                case 3:
                    Console.WriteLine("[3] Multiplicacion");
                    operacion.Multiplicacion();
                    break;
                case 4:
                    Console.WriteLine("[4] Division");
                    operacion.Division();

                    break;
                //Henry
                case 5:
                    Console.WriteLine("[5] Potencia");
                    operacion.Potencia();
                    break;
                case 6:
                    Console.WriteLine("[6] Raíz Cuadrada");
                    operacion.Radical();
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta...");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("REGRESANDO AL MENU");
                break;
            }
        } while (opcionMenu != 7) ;
    }
}