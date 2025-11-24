using Ejercicio3_.Models;
using System.Text.RegularExpressions;

namespace Ejercicio3_
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            string expresion =textBox1.Text;

            #region importar vehiculos y multas

            Regex regex = new Regex(@"<multa>[\s\S]*?</multa>", RegexOptions.IgnoreCase);
            Match match=regex.Match(expresion);

            while (match.Success)
            {
                string objectXML = match.Value;

                Vehiculo nuevo = new Vehiculo();
                if (nuevo.Importar(objectXML))
                {
                    vehiculos.Sort();
                    int idx = vehiculos.BinarySearch(nuevo);
                    if (idx > -1)
                    {
                        //vehiculos[idx].AgregarMulta(nuevo.VerMulta(0));
                        for(int n=0; n<nuevo.CantidadMultas;n++)
                            vehiculos[idx].AgregarMulta(nuevo.VerMulta(n));
                    }
                    else
                    {
                        vehiculos.Add(nuevo);
                    }
                }

                match=match.NextMatch(); 
            }

            #endregion

            #region imprimir vehiculos
            //listBox1.Items.AddRange(vehiculos.ToArray());
            foreach (Vehiculo v in vehiculos)
            {
                listBox1.Items.Add(v);
            }
            #endregion

        }
    }
}
