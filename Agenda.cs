using System;
using System.Collections.Generic;
using System.Linq;

public class Agenda
{
    private readonly List<Contacto> contactos = new List<Contacto>();

    public void AgregarContacto()
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine()?.Trim();

        if (string.IsNullOrWhiteSpace(nombre))
        {
            Console.WriteLine("❌ Nombre inválido.");
            return;
        }

        if (contactos.Any(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine("❌ Ya existe un contacto con ese nombre.");
            return;
        }

        Console.Write("Teléfono: ");
        string telefono = Console.ReadLine()?.Trim();

        Console.Write("Email: ");
        string email = Console.ReadLine()?.Trim();

        contactos.Add(new Contacto
        {
            Nombre = nombre,
            Telefono = telefono ?? "",
            Email = email ?? ""
        });

        Console.WriteLine("✅ Contacto agregado.");
    }

    public void ListarContactos()
    {
        if (contactos.Count == 0)
        {
            Console.WriteLine("📭 No hay contactos registrados.");
            return;
        }

        Console.WriteLine("\n--- LISTA DE CONTACTOS ---");
        foreach (var c in contactos.OrderBy(c => c.Nombre))
        {
            Console.WriteLine(c);
        }
    }

    public void BuscarContacto()
    {
        Console.Write("Buscar por nombre: ");
        string q = Console.ReadLine()?.Trim();

        if (string.IsNullOrWhiteSpace(q))
        {
            Console.WriteLine("❌ Búsqueda inválida.");
            return;
        }

        var resultados = contactos
            .Where(c => c.Nombre.Contains(q, StringComparison.OrdinalIgnoreCase))
            .ToList();

        if (resultados.Count == 0)
        {
            Console.WriteLine("🔎 No se encontraron coincidencias.");
            return;
        }

        Console.WriteLine("\n--- RESULTADOS ---");
        foreach (var c in resultados)
        {
            Console.WriteLine(c);
        }
    }

    public void EliminarContacto()
    {
        Console.Write("Nombre exacto a eliminar: ");
        string nombre = Console.ReadLine()?.Trim();

        if (string.IsNullOrWhiteSpace(nombre))
        {
            Console.WriteLine("❌ Nombre inválido.");
            return;
        }

        var contacto = contactos.FirstOrDefault(c =>
            c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

        if (contacto == null)
        {
            Console.WriteLine("❌ No existe ese contacto.");
            return;
        }

        contactos.Remove(contacto);
        Console.WriteLine("✅ Contacto eliminado.");
    }
}
