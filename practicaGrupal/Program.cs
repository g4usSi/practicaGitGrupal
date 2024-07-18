using practicaGrupal;

class Program {
    public static void Main(String[] args)
    {
        Operaciones operacion = new Operaciones();
        int numeroIntroducido1;
        int numeroIntroducido2;
        int opcionMenu;

        Console.WriteLine("Calculadora...");
        do
        {
           


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
                    operacion.Suma();
                    break;
                case 2:
                    break;
                //Geo
                case 3:
                    break;
                case 4:
                    break;
                //Henry
                case 5:
                    break;
                case 6:
                    break;
                default:
                break;       
            }
        } while (opcionMenu != 7);
    }
}

