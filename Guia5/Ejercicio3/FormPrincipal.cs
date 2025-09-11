using Ejercicio3.Models;
using System.Text.RegularExpressions;

namespace Ejercicio3;

public partial class FormPrincipal : Form
{
    
    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void btnImportarXML_Click(object sender, EventArgs e)
    {
        List<Vehiculo> list = new List<Vehiculo>();

        string contenido = tbXMLContenido.Text;

        Regex regex = new Regex(@"<multa>[\s\S]*?</multa>", RegexOptions.IgnoreCase);

        Match math=regex.Match(contenido);

        lsbVer.Items.Clear();
        while(math.Success)
        {
            lsbVer.Items.Add(math.Value);

            Vehiculo nuevo = new Vehiculo();

            if (nuevo.Importar(math.Value))
            {
                int idx = list.BinarySearch(nuevo);
                if (idx > -1)
                {
                    for(int n=0; n<nuevo.CantidadMultas; n++)
                        list[idx].AgregarMulta(nuevo.VerMulta(n));
                }
                else
                    list.Add(nuevo);
            }

            math=math.NextMatch();
        }

        lsbVer.Items.Clear();
        foreach (Vehiculo v in list)
        {
            lsbVer.Items.Add( v.ToString().Trim() );
        }
    }
}
