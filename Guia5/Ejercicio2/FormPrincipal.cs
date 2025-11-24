using System.Text;

namespace Ejercicio2;

public partial class FormPrincipal : Form
{
    static Random azar =new Random();
    public FormPrincipal()
    {
        InitializeComponent();

    }

    List<string> nombres = new List<string> {
        "Hernandez", "Saavedra", "Acosta", "Jacob", "Heinze", "Fischer", "Campos"
    };
    List<string> apellidos = new List<string>
    {
        "Adriana", "Elizabet", "José", "María", "Ernesto", "Sebastian", "Julio", "Ester", "Ariel", "Betiana", "Silvina", "Ana", "Leandro", "Ayelen", "Daniela", "Miguel"
    };

    private void btnGenerarListado_Click(object sender, EventArgs e)
    {
        StringBuilder listado=new StringBuilder();
        for (int n = 0; n < 10000; n++)
        {
            int o= azar.Next(nombres.Count);
            int p= azar.Next(apellidos.Count);

            listado.AppendLine($"{apellidos[p]}, {nombres[o]}");            
        }

        tbApellidosNombres.Text = listado.ToString();
    }
}
