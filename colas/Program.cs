using colas;

bool salir = false;

while (!salir)
{
    Console.WriteLine();
    Console.WriteLine("===== ATENCIÓN DE CLIENTES DEL BANCO =====");
    Console.WriteLine("1. Agregar cliente a la cola");
    Console.WriteLine("2. Atender siguiente cliente");
    Console.WriteLine("3. Listar clientes esperando");
    Console.WriteLine("4. Mostrar cliente actualmente atendido");
    Console.WriteLine("0. Salir");
    Console.Write("Seleccione una opción: ");

    string? opcion = Console.ReadLine();

    Console.WriteLine();

    switch (opcion)
    {
        case "1":
            colas_clientes.AgregarCliente();
            break;

        case "2":
            colas_clientes.AtenderCliente();
            break;

        case "3":
            colas_clientes.ListarClientes();
            break;

        case "4":
            colas_clientes.MostrarClienteAtendido();
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
