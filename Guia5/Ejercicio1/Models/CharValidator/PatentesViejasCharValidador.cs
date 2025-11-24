namespace Ejercicio1.Models.CharValidator;

public class PatentesViejasCharValidador:Validador
{
    public PatentesViejasCharValidador(string expresion):base(expresion)
    {
        MENSAJE_ERROR = "Formato Viejo de patente incorrecto";
        MENSAJE_OK = "Formato Viejo de patente Correcto";
    }

    override public bool Validar()
    {
        int cantG1=0;
        int cantG2=0;
        int cantG3=0;

        for (int n = 0; n < expresion.Length; n++)
        {
            if (char.IsLetter(expresion[n]) && cantG1 == n) //que sea letra y consecutivo
                cantG1++;
            else if (expresion[n]==' ' && cantG2+3 == n) //que sea separador y consecutivo
                cantG2++;
            if (char.IsNumber(expresion[n]) && cantG3+cantG2+ cantG1 == n) //que sea letra y sepacios
                cantG3++;            
        }

        bool esValido = cantG1==3 && cantG2>0 && cantG3==3 && cantG1+cantG2+cantG3==expresion.Length;

        return esValido;
    }
}
