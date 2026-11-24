namespace pilas_colas
{

    // Las Pilas o Stacks es uno de los muchos tipos de estructuras de datos.
    // Es una collection de datos, que respeta el acrónimo LIFO, Last In, First Out
    // push - Apila un elemento a la pila.
    // pop - desapila un elemento.
    // peek - Nos da el primer elemento de la pila pero no lo desapila.
    public static class pilas_historial
    {
        private static readonly Stack<string> history = new();

        // Inicializa la pila con algunas páginas visitadas previamente.
        // Cada página nueva se coloca encima de la anterior, respetando LIFO.
        static pilas_historial()
        {
            history.Push("https://www.youtube.com");
            history.Push("https://www.google.com");
            history.Push("https://www.io.com");
        }

        // Solicita una página y la agrega en la cima de la pila.
        // Push hace que esta página se convierta en la página actual.
        public static void AddPage()
        {
            Console.WriteLine("Introduzca el nombre de la pagina para visitarla: ");

            Console.Write("https://");
            string? web = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(web))
            {
                Console.WriteLine("La página no puede estar vacía.");
                return;
            }

            history.Push("https://" + web.Trim());

            Console.WriteLine("Página agregada correctamente.");
        }

        // Consulta la página que está en la cima de la pila sin eliminarla.
        // Peek permite conocer la página actual y conservar el historial.
        public static void PaginaActual()
        {
            if (history.Count == 0)
            {
                Console.WriteLine("La pila no tiene elementos.");
                return;
            }

            Console.WriteLine("Página actual: " + history.Peek());
        }

        // Elimina la página actual para regresar a la página anterior.
        // Pop retira el elemento que está en la cima de la pila.
        public static void IrPaginaAnterior()
        {

            if (history.Count == 0)
            {
                Console.WriteLine(
                    "Visite páginas web para poder navegar entre distintas páginas del historial.");
                return;
            }

            history.Pop();

            if (history.Count == 0)
            {
                Console.WriteLine("No hay páginas anteriores.");
                return;
            }

            Console.WriteLine("Página actual: " + history.Peek());
        }

        // Muestra el historial desde la página más reciente hasta la más antigua.
        // ToArray crea una copia temporal y el for recorre esa copia sin modificar
        // la pila original.
        public static void VerHistorial()
        {
            if (history.Count == 0)
            {
                Console.WriteLine("La pila está vacía.");
                return;
            }

            string[] paginas = history.ToArray();

            Console.WriteLine("Historial:");

            for (int i = 0; i < paginas.Length; i++)
            {
                Console.WriteLine(paginas[i]);
            }
        }
    }
}
