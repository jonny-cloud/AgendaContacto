using System;

class Program
{
    static void Main()
    {
        var agenda = new Agenda();
        int opcion = -1;

        while (opcion != 0)
        {
            Console.WriteLine("\n===== AGENDA DE CONTACTOS =====");
            Console.WriteLine("1) Agregar contacto");
            Console.WriteLine("2) Listar contactos");
            Console.WriteLine("3) Buscar contacto");
            Console.WriteLine("4) Eliminar contacto");
            Console.WriteLine("0) Salir");
            Console.Write("Seleccione opción: ");

            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out opcion))
            {
                Console.WriteLine("❌ Ingrese un número válido.");
                opcion = -1;
                continue;
            }

            switch (opcion)
            {
                case 1: agenda.AgregarContacto(); break;
                case 2: agenda.ListarContactos(); break;
                case 3: agenda.BuscarContacto(); break;
                case 4: agenda.EliminarContacto(); break;
                case 0: Console.WriteLine("👋 Saliendo..."); break;
                default: Console.WriteLine("❌ Opción inválida."); break;
            }
            //mejora Luis
            Console.WriteLine("\nPresione ENTER para continuar...");
            Console.ReadLine();
        }
    }
}
