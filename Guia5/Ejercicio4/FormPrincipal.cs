using System.Text.RegularExpressions;

namespace Ejercicio4;

public partial class FormPrincipal : Form
{
    public FormPrincipal()
    {
        InitializeComponent();
    }

    string frase = @"
“La ratona y su sistema de datos orientados a objetos”  
Ilustración artística de Máxima Caceres Alba. 

El desarrollo de este curso tratará de enfocarse en dos partes. La primera parte se centrará en las propiedades de la programación orientada a objetos y la segunda parte comprenderá las clases principales de .NET para manejo de cadena de caracteres, manejo de fechas, manejo de excepciones, archivos y estructura de datos.

Sobre la ilustración y sus escenas.

El dibujo contiene tres escenas que buscan representar los conceptos involucrados en la programación orientada a objetos sobre la idea de clases y objetos. En la primera escena, la ratona por medio de las definiciones que lee del diccionario clasifica las partes de cada ratón mecánico agrupandolas en distintas canastas. En la segunda escena,  que es central en el dibujo y conecta la primera escena con la tercera, la ratona mientras  lee las definiciones en el diccionario toma una parte clasificada en una canasta y construye un ratón mecánico. En la última escena, la ratona sigue atentamente las definiciones del diccionario controlando así que se cumplan los contratos que deben cumplir los objetos al interaccionar entre sí. 
";

    private void btnBuscar_Click(object sender, EventArgs e)
    {
        string palabra = textBox1.Text;

        string patron = $@"\b(?<palabra>{Regex.Escape(palabra)}\b)";
        Regex regex = new Regex(patron, RegexOptions.IgnoreCase);

        MatchCollection matches = regex.Matches(frase);
        lbCantidadPalabras.Text = matches.Count.ToString();

        string resultado = regex.Replace(frase, @"{\b ${palabra}}");
        richTextBox1.Rtf = $@"{{\rtf1\ansi {resultado}}}";

        foreach (Match match in matches)
        {
            string palabraEncontrada = match.Groups["palabra"].Value;
        //    //int posicion = match.Index;
        //    //richTextBox1.Select(match.Index, match.Length);
        //    //richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
        //    //richTextBox1.SelectionColor = Color.Red;
        }
    }

    private void FormPrincipal_Load(object sender, EventArgs e)
    {
        richTextBox1.Rtf= $@"{{\rtf1\ansi {frase}}}";
    }
}
