namespace Ejercicio2
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            tbApellidosNombres = new TextBox();
            btnGenerarListado = new Button();
            SuspendLayout();
            // 
            // tbApellidosNombres
            // 
            tbApellidosNombres.Font = new Font("Courier New", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbApellidosNombres.Location = new Point(4, 15);
            tbApellidosNombres.Margin = new Padding(5, 6, 5, 6);
            tbApellidosNombres.Multiline = true;
            tbApellidosNombres.Name = "tbApellidosNombres";
            tbApellidosNombres.ScrollBars = ScrollBars.Both;
            tbApellidosNombres.Size = new Size(375, 613);
            tbApellidosNombres.TabIndex = 14;
            tbApellidosNombres.WordWrap = false;
            // 
            // btnGenerarListado
            // 
            btnGenerarListado.Location = new Point(389, 243);
            btnGenerarListado.Margin = new Padding(5, 6, 5, 6);
            btnGenerarListado.Name = "btnGenerarListado";
            btnGenerarListado.Size = new Size(134, 131);
            btnGenerarListado.TabIndex = 13;
            btnGenerarListado.Text = "Generar Listado";
            btnGenerarListado.UseVisualStyleBackColor = true;
            btnGenerarListado.Click += btnGenerarListado_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 634);
            Controls.Add(tbApellidosNombres);
            Controls.Add(btnGenerarListado);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormPrincipal";
            Text = "Ejercicio 2";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbApellidosNombres;
        private System.Windows.Forms.Button btnGenerarListado;
    }
}

