namespace Ordenamiento_por_seleecion
{
    partial class SumaDeLosNumeros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnInsertar = new Button();
            btnSumar = new Button();
            txtNumero = new TextBox();
            lstNumeros = new ListBox();
            SuspendLayout();
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(263, 39);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 0;
            btnInsertar.Text = "Insertar";
            btnInsertar.TextAlign = ContentAlignment.BottomCenter;
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(353, 39);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(75, 23);
            btnSumar.TabIndex = 1;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(131, 39);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 2;
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.ItemHeight = 15;
            lstNumeros.Location = new Point(131, 87);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(108, 214);
            lstNumeros.TabIndex = 3;
            // 
            // SumaDeLosNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 333);
            Controls.Add(lstNumeros);
            Controls.Add(txtNumero);
            Controls.Add(btnSumar);
            Controls.Add(btnInsertar);
            Name = "SumaDeLosNumeros";
            Text = "SumaDeLosNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsertar;
        private Button btnSumar;
        private TextBox txtNumero;
        private ListBox lstNumeros;
    }
}