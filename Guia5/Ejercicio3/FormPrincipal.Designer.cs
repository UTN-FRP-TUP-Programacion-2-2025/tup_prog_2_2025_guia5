namespace Ejercicio3
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
            tbXMLContenido = new TextBox();
            btnImportarXML = new Button();
            lsbVer = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // tbXMLContenido
            // 
            tbXMLContenido.Location = new Point(13, 34);
            tbXMLContenido.Margin = new Padding(4);
            tbXMLContenido.Multiline = true;
            tbXMLContenido.Name = "tbXMLContenido";
            tbXMLContenido.ScrollBars = ScrollBars.Both;
            tbXMLContenido.Size = new Size(337, 283);
            tbXMLContenido.TabIndex = 0;
            // 
            // btnImportarXML
            // 
            btnImportarXML.Location = new Point(358, 116);
            btnImportarXML.Margin = new Padding(4);
            btnImportarXML.Name = "btnImportarXML";
            btnImportarXML.Size = new Size(102, 91);
            btnImportarXML.TabIndex = 1;
            btnImportarXML.Text = "Importar XML";
            btnImportarXML.UseVisualStyleBackColor = true;
            btnImportarXML.Click += btnImportarXML_Click;
            // 
            // lsbVer
            // 
            lsbVer.FormattingEnabled = true;
            lsbVer.ItemHeight = 21;
            lsbVer.Location = new Point(12, 370);
            lsbVer.Margin = new Padding(4);
            lsbVer.Name = "lsbVer";
            lsbVer.Size = new Size(338, 235);
            lsbVer.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(41, 21);
            label1.TabIndex = 3;
            label1.Text = "XML";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 345);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 4;
            label2.Text = "Resumen";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 615);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lsbVer);
            Controls.Add(btnImportarXML);
            Controls.Add(tbXMLContenido);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 3";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox tbXMLContenido;
        private Button btnImportarXML;
        private ListBox lsbVer;
        private Label label1;
        private Label label2;
    }
}

