// See https://aka.ms/new-console-template for more information
using System.Data.Common;

Console.WriteLine("Compila correctamente");

public class PRODUCTOS
{
    private int IDPRODUCTO;
    private string? nombreproducto;
}
public class JUGUETES : PRODUCTOS
{
    private List<JUGUETES>? JUGUETE;
    private DateTime? fecha_salida;
}
public class PERSONAS
{
    private int IDPERSONA;
}
public class CLIENTES : PERSONAS
{
    private List<PERSONAS>? PERSONA;
    private string? nombre;
}
