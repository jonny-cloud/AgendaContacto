public class Contacto
{
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }

    public override string ToString()
    {
        return $"{Nombre} | {Telefono} | {Email}";
    }
}
