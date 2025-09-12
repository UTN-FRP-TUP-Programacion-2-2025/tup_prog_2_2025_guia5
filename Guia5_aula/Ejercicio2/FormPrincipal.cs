using System.Text;

namespace Ejercicio2_
{
    public partial class FormPrincipal : Form
    {
        static Random azar=new Random();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        List<string> nombres = new List<string> { "Juan" };
        List<string> apellidos = new List<string> { "Martinez" };

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int n = 0; n < 10000; n++)
            {
                int p=azar.Next(0, apellidos.Count);
                int q = azar.Next(0, nombres.Count);

                sb.AppendLine($"{apellidos[p]}, {nombres[q]}");
            }

            textBox1.Text= sb.ToString();

            listBox1.Items.AddRange(sb.ToString().Split("\n"));
        }
    }
}
