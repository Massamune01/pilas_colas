namespace pilas_colas
{

    // Las Pilas o Stacks es uno de los muchos tipos de estructuras de datos.
    // Es una collection de datos, que respeta el acrónimo LIFO, Last In, First Out
    // push - Apila un elemento a la pila.
    // pop - desapila un elemento.
    // peek - Nos da el primer elemento de la pila pero no lo desapila.
    public static class pilas_historial_web
    {
        static Stack<string> history;

        static public void next_page()
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
            }
            else
            {

            }

            string actual_page = history.Peek();

            Console.WriteLine("Pagina Actual: " + actual_page);
        }
    }
}
