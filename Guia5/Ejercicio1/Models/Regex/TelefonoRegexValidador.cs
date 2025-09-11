using System.Text.RegularExpressions;

namespace Ejercicio1.Models.CharValidator;

public class TelefonoRegexValidador: TelefonoCharValidador
{
    public TelefonoRegexValidador(string expresion):base(expresion)
    {
    }

    override public bool Validar()
    {
        Regex regex = new Regex(@"[0-9]{3}-{1}[0-9]{7}");
        return regex.Count(expresion) == 1;
    }
}
