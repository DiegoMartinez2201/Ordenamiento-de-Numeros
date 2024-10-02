namespace Ordenamiento_por_seleecion
{
    partial class Ordenamiento_de_Mayor_a_Menor
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
            groupBox1 = new GroupBox();
            txtArrayOrdenado = new TextBox();
            btnOrdenar = new Button();
            txtArray = new TextBox();
            btnGenerar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtArrayOrdenado);
            groupBox1.Controls.Add(btnOrdenar);
            groupBox1.Controls.Add(txtArray);
            groupBox1.Controls.Add(btnGenerar);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(131, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(530, 308);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Array";
            // 
            // txtArrayOrdenado
            // 
            txtArrayOrdenado.Location = new Point(109, 165);
            txtArrayOrdenado.Name = "txtArrayOrdenado";
            txtArrayOrdenado.Size = new Size(305, 23);
            txtArrayOrdenado.TabIndex = 3;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(229, 119);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(75, 23);
            btnOrdenar.TabIndex = 2;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // txtArray
            // 
            txtArray.Location = new Point(109, 72);
            txtArray.Name = "txtArray";
            txtArray.Size = new Size(305, 23);
            txtArray.TabIndex = 1;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(229, 32);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(75, 23);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // Ordenamiento_de_Mayor_a_Menor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Ordenamiento_de_Mayor_a_Menor";
            Text = "Ordenamiento_de_Mayor_a_Menor";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtArrayOrdenado;
        private Button btnOrdenar;
        private TextBox txtArray;
        private Button btnGenerar;
    }
}