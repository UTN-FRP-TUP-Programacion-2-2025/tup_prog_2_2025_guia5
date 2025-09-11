namespace Ejercicio1
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            btnProcesar = new Button();
            lsbVerChar = new ListBox();
            btnValidarRegex = new Button();
            lsbVerRegex = new ListBox();
            SuspendLayout();
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(3, 14);
            btnProcesar.Margin = new Padding(4, 5, 4, 5);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(372, 54);
            btnProcesar.TabIndex = 0;
            btnProcesar.Text = "Probar ejemplos char";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnValidarChar_Click;
            // 
            // lsbVerChar
            // 
            lsbVerChar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lsbVerChar.FormattingEnabled = true;
            lsbVerChar.Location = new Point(3, 76);
            lsbVerChar.Name = "lsbVerChar";
            lsbVerChar.Size = new Size(372, 500);
            lsbVerChar.TabIndex = 1;
            // 
            // btnValidarRegex
            // 
            btnValidarRegex.Location = new Point(381, 14);
            btnValidarRegex.Margin = new Padding(4, 5, 4, 5);
            btnValidarRegex.Name = "btnValidarRegex";
            btnValidarRegex.Size = new Size(372, 54);
            btnValidarRegex.TabIndex = 3;
            btnValidarRegex.Text = "Probar ejemplos regex";
            btnValidarRegex.UseVisualStyleBackColor = true;
            btnValidarRegex.Click += btnValidarRegex_Click;
            // 
            // lsbVerRegex
            // 
            lsbVerRegex.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lsbVerRegex.FormattingEnabled = true;
            lsbVerRegex.Location = new Point(381, 76);
            lsbVerRegex.Name = "lsbVerRegex";
            lsbVerRegex.Size = new Size(372, 500);
            lsbVerRegex.TabIndex = 2;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 584);
            Controls.Add(btnValidarRegex);
            Controls.Add(lsbVerRegex);
            Controls.Add(lsbVerChar);
            Controls.Add(btnProcesar);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormPrincipal";
            Text = "Ejercicio 1";
            Load += FormPrincipal_Load;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProcesar;
        private ListBox lsbVerChar;
        private Button btnValidarRegex;
        private ListBox lsbVerRegex;
    }
}

