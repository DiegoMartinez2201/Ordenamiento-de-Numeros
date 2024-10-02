namespace Ordenamiento_por_seleecion
{
    partial class Ordenamiento_Pares
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
            btnOrdenar = new Button();
            label1 = new Label();
            txtNumeros = new TextBox();
            listBoxPares = new ListBox();
            SuspendLayout();
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(317, 156);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(101, 33);
            btnOrdenar.TabIndex = 0;
            btnOrdenar.Text = "Ordenar Pares";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 68);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingresa los números:";
            label1.Click += label1_Click;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(231, 101);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(264, 23);
            txtNumeros.TabIndex = 2;
            // 
            // listBoxPares
            // 
            listBoxPares.FormattingEnabled = true;
            listBoxPares.ItemHeight = 15;
            listBoxPares.Location = new Point(307, 217);
            listBoxPares.Name = "listBoxPares";
            listBoxPares.Size = new Size(120, 94);
            listBoxPares.TabIndex = 3;
            // 
            // Ordenamiento_Pares
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxPares);
            Controls.Add(txtNumeros);
            Controls.Add(label1);
            Controls.Add(btnOrdenar);
            Name = "Ordenamiento_Pares";
            Text = "Ordenamiento_Pares";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOrdenar;
        private Label label1;
        private TextBox txtNumeros;
        private ListBox listBoxPares;
    }
}