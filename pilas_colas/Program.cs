using pilas_colas;

bool salir = false;

while (!salir)
{
    Console.WriteLine();
    Console.WriteLine("===== HISTORIAL DEL NAVEGADOR =====");
    Console.WriteLine("1. Visitar una página");
    Console.WriteLine("2. Mostrar página actual");
    Console.WriteLine("3. Ir a la página anterior");
    Console.WriteLine("4. Ver historial");
    Console.WriteLine("0. Salir");
    Console.Write("Seleccione una opción: ");

    string? opcion = Console.ReadLine();

    Console.WriteLine();

    switch (opcion)
    {
        case "1":
            pilas_historial.AddPage();
            break;

        case "2":
            pilas_historial.PaginaActual();
            break;

        case "3":
            pilas_historial.IrPaginaAnterior();
            break;

        case "4":
            pilas_historial.VerHistorial();
            break;

        case "0":
            salir = true;
            Console.WriteLine("Programa finalizado.");
            break;

        default:
            Console.WriteLine("Opción no válida. Intente nuevamente.");
            break;
    }

    if (!salir)
    {
        Console.WriteLine();
        Console.WriteLine("Presione ENTER para continuar...");
        Console.ReadLine();
    }
}