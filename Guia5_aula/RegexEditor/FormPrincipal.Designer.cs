namespace RegexEditor
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
            tbContenido = new TextBox();
            tbResultado = new TextBox();
            btnVerResultado = new Button();
            tbPatron = new TextBox();
            chxEsGrupo = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // tbContenido
            // 
            tbContenido.Font = new Font("Microsoft Sans Serif", 9.75F);
            tbContenido.Location = new Point(11, 88);
            tbContenido.Margin = new Padding(6, 8, 6, 8);
            tbContenido.Multiline = true;
            tbContenido.Name = "tbContenido";
            tbContenido.ScrollBars = ScrollBars.Both;
            tbContenido.Size = new Size(705, 140);
            tbContenido.TabIndex = 8;
            // 
            // tbResultado
            // 
            tbResultado.Font = new Font("Microsoft Sans Serif", 9.75F);
            tbResultado.Location = new Point(11, 409);
            tbResultado.Margin = new Padding(6, 8, 6, 8);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.ScrollBars = ScrollBars.Both;
            tbResultado.Size = new Size(705, 125);
            tbResultado.TabIndex = 9;
            // 
            // btnVerResultado
            // 
            btnVerResultado.Location = new Point(728, 125);
            btnVerResultado.Margin = new Padding(6, 8, 6, 8);
            btnVerResultado.Name = "btnVerResultado";
            btnVerResultado.Size = new Size(184, 122);
            btnVerResultado.TabIndex = 10;
            btnVerResultado.Text = "Ver Resultado";
            btnVerResultado.UseVisualStyleBackColor = true;
            btnVerResultado.Click += btnVerResultado_Click;
            // 
            // tbPatron
            // 
            tbPatron.Font = new Font("Microsoft Sans Serif", 9.75F);
            tbPatron.Location = new Point(11, 264);
            tbPatron.Margin = new Padding(6, 8, 6, 8);
            tbPatron.Multiline = true;
            tbPatron.Name = "tbPatron";
            tbPatron.ScrollBars = ScrollBars.Both;
            tbPatron.Size = new Size(705, 109);
            tbPatron.TabIndex = 11;
            // 
            // chxEsGrupo
            // 
            chxEsGrupo.AutoSize = true;
            chxEsGrupo.Location = new Point(755, 260);
            chxEsGrupo.Margin = new Padding(4, 5, 4, 5);
            chxEsGrupo.Name = "chxEsGrupo";
            chxEsGrupo.Size = new Size(133, 24);
            chxEsGrupo.TabIndex = 12;
            chxEsGrupo.Text = "Imprimir Group";
            chxEsGrupo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 236);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 13;
            label1.Text = "Patrón";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 381);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 14;
            label2.Text = "Salida";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 60);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 15;
            label3.Text = "Contenido";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(109, 24);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(607, 28);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 27);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 17;
            label4.Text = "Ejemplos";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 541);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chxEsGrupo);
            Controls.Add(tbPatron);
            Controls.Add(btnVerResultado);
            Controls.Add(tbResultado);
            Controls.Add(tbContenido);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormPrincipal";
            Text = "Regex editor";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbContenido;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Button btnVerResultado;
        private System.Windows.Forms.TextBox tbPatron;
        private System.Windows.Forms.CheckBox chxEsGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
    }
}

