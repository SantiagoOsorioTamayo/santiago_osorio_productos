// See https://aka.ms/new-console-template for more information
using System.Data.Common;

Console.WriteLine("Compila correctamente");

public class PRODUCTOS
{
    private int IDPRODUCTO;
    private string? NOMBREPRODUCTO;
}
public class JUGUETES : PRODUCTOS
{
    private List<JUGUETES>? JUGUETE;
    private DateTime? FECHA_SALIDA;
}
public class PERSONAS
{
    private int IDPERSONA;
}
public class CLIENTES : PERSONAS
{
    private List<PERSONAS>? PERSONA;
    private string? NOMBRE;
}
