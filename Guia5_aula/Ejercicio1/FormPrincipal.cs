namespace Ejercicio1_
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string expresion = textBox1.Text;

            int cantNumeros=0;
            for (int n = 0; n < expresion.Length; n++)
            {
                if (char.IsNumber(expresion[n]) == true)
                {
                    cantNumeros++;
                }
            }

            if (cantNumeros == expresion.Length)
            {
                textBox2.Text = "es valido";
            }
            else
            {
                textBox2.Text = "no es valido";
            }
        }
    }
}
