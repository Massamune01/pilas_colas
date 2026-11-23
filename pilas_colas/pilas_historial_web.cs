namespace pilas_colas
{

    // Las Pilas o Stacks es uno de los muchos tipos de estructuras de datos.
    // Es una collection de datos, que respeta el acrónimo LIFO, Last In, First Out
    // push - Apila un elemento a la pila.
    // pop - desapila un elemento.
    // peek - Nos da el primer elemento de la pila pero no lo desapila.
    public static class pilas_historial
    {
        static Stack<string> history;

        static public void AddPage()
        {
            Console.WriteLine("Introduzca el nombre de la pagina para visitarla: ");

            Console.Write("https:// ");
            string? web = Console.ReadLine();

            string push = "https://" + web;

            history.Push(push);

            Console.WriteLine("Completado");
        }

        static public void PaginaActual()
        {
            try 
            {
                string actual_page = history.Peek();

                Console.WriteLine("Pagina Actual: " + actual_page);
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine("La pila no tiene elementos.");
            }
        }

        static public void IrPaginaAnterior()
        {
            int count = history.Count();
            if (count > 0)
            {
                string back_page = history.Pop();

                if(history.Count() == 0)
                {
                    Console.WriteLine(back_page);
                    Console.WriteLine("Esa fue la ultima pagina");

                    return;
                }
                else
                {
                    string actual_page = history.Peek();

                    Console.WriteLine("Pagina Actual: " + actual_page);

                    return;
                }
            }
            else
            {
                Console.WriteLine("Visita a paginas web para poder navegar entre distintas paginas del historial.");
            }
        }

        static public void VerHistorial()
        {
            Stack<string> clone_pila = history;

            try
            {
                Console.WriteLine("Historial:");
                while(clone_pila.Count > 0)
                {
                    Console.WriteLine(clone_pila.Pop());
                }
                Console.WriteLine("Completado");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("La pila esta vacia");
            }
        }
    }
}
