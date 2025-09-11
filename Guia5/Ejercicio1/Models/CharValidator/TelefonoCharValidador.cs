namespace Ejercicio1.Models.CharValidator;

public class TelefonoCharValidador:Validador
{
    public TelefonoCharValidador(string expresion):base(expresion)
    {
        MENSAJE_ERROR = "Número de teléfono incorrecto";
        MENSAJE_OK = "Número de teléfono Correcto";
    }

    override public bool Validar()
    {
        int grupo1 = 0;
        int grupo2 = 0;
        int grupo3 = 0;

        for(int n=0; n< expresion.Length; n++)
        {
            if (char.IsNumber(expresion[n]) && grupo1 == n) //letra y consecutivo
            {
                grupo1++;
            }
            else if (expresion[n] == '-' && grupo1 + grupo2 == n) //letra y consecutivo
            {
                grupo2++;
            }
            else if (char.IsNumber(expresion[n]) && grupo1 + grupo2 + grupo3 == n) //letra y consecutivo
            {
                grupo3++;
            }
        }

        return (grupo1==3 || grupo1==4) && grupo2 == 1 && grupo3 ==7 && grupo1+grupo2+grupo3==expresion.Length;        
    }
}
