using practicaGrupal;

class Program {

    public static void Main(String[] args)
    {
        Operaciones operacion = new Operaciones();
        double numeroIntroducido1;
        double numeroIntroducido2;
        int opcionMenu;

        static void PedirNumeros()
        {

            operacion.Pedir();
            Console.WriteLine("Menu");
            Console.WriteLine("[1] Suma");
            Console.WriteLine("[2] Resta");
            Console.WriteLine("[3] Multiplicacion");
            Console.WriteLine("[4] Division");
            Console.WriteLine("[5] Potencia");
            Console.WriteLine("[6] Raiz");
            Console.WriteLine("[7] Salir");
            Console.WriteLine("Ingrese una opcion: ");
            opcionMenu = Convert.ToInt32(Console.ReadLine());
            switch (opcionMenu)
            {
                //Jenny
                case 1:
                    Console.WriteLine("[3] Suma");
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
                break;       
            }
        } while (opcionMenu != 7);
    }
}
