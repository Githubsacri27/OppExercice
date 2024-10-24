using Family;

namespace ConsoleFamily
{
     class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de la clase Son con valores iniciales
            Son son = new Son("Ruben", 39, "Blue", "Engineer", "ESP", "Barcelona", "Spanish", "Bike", "Zelda, Mario" );
            bool continuar = true;

            while (continuar)
            {
                // Mostrar el menú
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Mostrar valores");
                Console.WriteLine("2. Modificar valores");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                // Leer la opción del usuario
                int option;
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case 1:
                            // Mostrar valores actuales
                            son.ShowValues();
                            break;
                        case 2:
                            // Modificar valores
                            son.ModifyValues();
                            break;
                        case 3:
                            // Salir del programa
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
                }
            }

            Console.WriteLine("Saliendo del programa...");
        }
    }
}
