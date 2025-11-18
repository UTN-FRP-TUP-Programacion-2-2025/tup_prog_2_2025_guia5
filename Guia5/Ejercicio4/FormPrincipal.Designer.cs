namespace Ejercicio4
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            btnBuscar = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            lbCantidadPalabras = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(11, 69);
            richTextBox1.Margin = new Padding(4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(624, 404);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(539, 17);
            btnBuscar.Margin = new Padding(4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(96, 32);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 17);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(514, 29);
            textBox1.TabIndex = 2;
            textBox1.Text = "ratona";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 490);
            label1.Name = "label1";
            label1.Size = new Size(159, 21);
            label1.TabIndex = 3;
            label1.Text = "Cantidad de palabras:";
            // 
            // lbCantidadPalabras
            // 
            lbCantidadPalabras.BackColor = SystemColors.ActiveCaption;
            lbCantidadPalabras.Location = new Point(258, 490);
            lbCantidadPalabras.Name = "lbCantidadPalabras";
            lbCantidadPalabras.Size = new Size(118, 21);
            lbCantidadPalabras.TabIndex = 4;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 537);
            Controls.Add(lbCantidadPalabras);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btnBuscar);
            Controls.Add(richTextBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ejercicio 4";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnBuscar;
        private TextBox textBox1;
        private Label label1;
        private Label lbCantidadPalabras;
    }
}
