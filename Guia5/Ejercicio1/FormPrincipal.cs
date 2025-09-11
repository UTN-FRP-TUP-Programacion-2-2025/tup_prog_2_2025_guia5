using Ejercicio1.Models.CharValidator;

namespace Ejercicio1;

public partial class FormPrincipal : Form
{
    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void FormPrincipal_Load(object sender, EventArgs e)
    {
    }

    List<string> telefonos = new List<string>() { "2324-2456556", "343-4817427", "2324-245a556", "343–-4817427", "343–-4817427-34", "2324-a-2456556" };
    List<string> patentesViejas = new List<string>() { "ABC 123", "ABC123", "123 ABC", "ABC 1 123", "ABC 123 1", "ABC A 123", "ABC A 123 B" };

    private void btnValidarChar_Click(object sender, EventArgs e)
    {
        lsbVerChar.Items.Clear();

        lsbVerChar.Items.Add($"Validación de telefonos.");
        foreach (string telefono in telefonos)
        {
            TelefonoCharValidador telefonoValidador = new TelefonoCharValidador(telefono);
            lsbVerChar.Items.Add($"{telefono}, resultado: {telefonoValidador.VerMensaje()}");
        }
        lsbVerChar.Items.Add($"");


        lsbVerChar.Items.Add($"Validación de patentes - formato viejo.");
        foreach (string patente in patentesViejas)
        {
            PatentesViejasCharValidador patentesValidador = new PatentesViejasCharValidador(patente);
            lsbVerChar.Items.Add($"{patente}, resultado: {patentesValidador.VerMensaje()}");
        }

        lsbVerChar.Items.Add($"completar los otros");
    }

    private void btnValidarRegex_Click(object sender, EventArgs e)
    {
        lsbVerRegex.Items.Clear();

        lsbVerRegex.Items.Add($"Validación de telefonos.");
        foreach (string telefono in telefonos)
        {
            TelefonoRegexValidador telefonoValidador = new TelefonoRegexValidador(telefono);
            lsbVerRegex.Items.Add($"{telefono}, resultado: {telefonoValidador.VerMensaje()}");
        }
        lsbVerRegex.Items.Add($"");

        lsbVerRegex.Items.Add($"completar los otros");        
    }
}
