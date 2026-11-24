namespace colas
{
    public static class colas_clientes
    {
        private static readonly Queue<string> clientes = new();
        private static string? clienteAtendido;

        // Solicita el nombre de un cliente y lo agrega al final de la cola.
        // Enqueue conserva el orden de llegada: el primer cliente agregado
        // será el primero en ser atendido.
        public static void AgregarCliente()
        {
            Console.Write("Ingrese el nombre del cliente: ");
            string? nombre = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                Console.WriteLine("El nombre del cliente no puede estar vacío.");
                return;
            }

            clientes.Enqueue(nombre.Trim());
            Console.WriteLine("Cliente agregado a la cola.");
        }

        // Atiende al primer cliente de la cola.
        // Dequeue extrae el elemento que lleva más tiempo esperando y lo
        // guarda en clienteAtendido para poder mostrarlo después.
        public static void AtenderCliente()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("No hay clientes esperando.");
                return;
            }

            clienteAtendido = clientes.Dequeue();
            Console.WriteLine("Cliente atendido: " + clienteAtendido);
        }

        // Muestra todos los clientes que todavía están esperando.
        // ToArray crea una copia temporal para recorrerla con un for sin
        // eliminar los clientes de la cola original.
        public static void ListarClientes()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("No hay clientes esperando.");
                return;
            }

            string[] clientesEsperando = clientes.ToArray();

            Console.WriteLine("Clientes esperando:");

            for (int i = 0; i < clientesEsperando.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {clientesEsperando[i]}");
            }
        }

        // Muestra el último cliente que fue retirado de la cola para ser
        // atendido. Si todavía no se ha atendido ninguno, informa esa situación.
        public static void MostrarClienteAtendido()
        {
            if (clienteAtendido is null)
            {
                Console.WriteLine("Todavía no se ha atendido ningún cliente.");
                return;
            }

            Console.WriteLine("Cliente que está siendo atendido: " + clienteAtendido);
        }
    }
}
