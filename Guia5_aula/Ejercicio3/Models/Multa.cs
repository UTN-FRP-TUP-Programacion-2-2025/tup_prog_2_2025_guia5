
namespace Ejercicio3_.Models;

public class Multa
{
    public double Importe { get; set; } 

    public Multa()
    {
    }

    public Multa(double importe)
    {
        Importe = importe;
    }

    override public string ToString()
    {
        return "";
    }
}
