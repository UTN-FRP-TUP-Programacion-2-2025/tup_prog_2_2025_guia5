using System.Text.RegularExpressions;

namespace Ejercicio3.Models;

public class Vehiculo : IImportable, IComparable<Vehiculo>
{
    public string Patente { get; set; }
    public int CantidadMultas { get { return multas.Count; } }
    public double ImporteTotal { get; private set; }
    
    List<Multa> multas =new List<Multa>();

    public Vehiculo()
    {
    }

    public Vehiculo(string patente)
    { 
        Patente = patente;
    }

    public void AgregarMulta(Multa multa)
    {
        multas.Add(multa);
        ImporteTotal += multa.Valor;
    }

    public Multa VerMulta(int idx)
    {
        if (idx >= 0 && idx < multas.Count)
        { 
            return multas[idx];
        }
        return null;
    }

    public bool Importar(string xml)
    {
        //<multa> \r\n  <patente>ACE 232</patente>\r\n  <deuda>234556,00</deuda>\r\n</multa>
        Regex regex = new Regex(@"[\s]*?<patente>([\w\s]+?)</patente>[\s]*?", RegexOptions.IgnoreCase);
        Match match = regex.Match(xml);
        if (match.Success==false)
            return false;

        Patente = match.Groups[1].Value;

        Multa multa = new Multa();
        AgregarMulta (multa);

        if (multa.Importar(xml) == false) return false;

        ImporteTotal=multa.Valor;

        return true;
    }

    public override string ToString()
    {
        return $"Patente:{Patente}, Importe Total: ${ImporteTotal}";
    }

    public int CompareTo(Vehiculo other)
    {
        Vehiculo otro = other as Vehiculo;
        if(otro!=null)
            return this.Patente.CompareTo(otro.Patente);
        return -1;
    }
}
