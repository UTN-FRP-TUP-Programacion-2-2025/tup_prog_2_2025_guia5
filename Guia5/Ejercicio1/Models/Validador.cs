namespace Ejercicio1.Models;

abstract public class Validador
{
    protected string expresion;
    protected string MENSAJE_ERROR = "";
    protected string MENSAJE_OK = "";

    public Validador(string expresion)
    {
        this.expresion = expresion;
    }

    virtual public string VerMensaje()
    {
        if (Validar()) return MENSAJE_OK;
        return MENSAJE_ERROR;
    }

    abstract public bool Validar();
}
