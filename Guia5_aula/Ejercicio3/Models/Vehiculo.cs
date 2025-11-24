

using System.Text.RegularExpressions;

namespace Ejercicio3_.Models;

public class Vehiculo:IComparable<Vehiculo>
{
    public string Patente{get;set;}
    public int CantidadMultas
    {
        get {
            return multas.Count;
        }
    }

    public double ImporteTotal
    {
        get; private set;
    }

    List<Multa> multas = new List<Multa>();

    public void AgregarMulta(Multa nueva)
    {
        multas.Add(nueva);
        ImporteTotal += nueva.Importe;
    }

    public Multa VerMulta(int idx)
    { 
        if(idx>=0 && idx<CantidadMultas)
            return multas[idx];
        return null;
    }

    public bool Importar(string xml)
    {
        Regex regex = new Regex(@"<patente>([\s\w]+?)</patente>", RegexOptions.IgnoreCase);
        Match match=regex.Match(xml);
        if(match.Groups.Count!=2) return false;

        Patente = match.Groups[1].Value;

        //llamando el importar de la multa

        return true;
    }

    public override string ToString()
    {
        return $"Patente: {Patente}; Importe Total: {ImporteTotal}";
    }

    public int CompareTo(Vehiculo? other)
    {
      return Patente.CompareTo(other?.Patente);
    }
}
