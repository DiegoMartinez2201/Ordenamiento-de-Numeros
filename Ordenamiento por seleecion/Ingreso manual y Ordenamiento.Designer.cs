namespace Ordenamiento_por_seleecion
{
    partial class Ingreso_manual_y_Ordenamiento
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
            label1 = new Label();
            txt_Valor = new TextBox();
            LstDatos = new ListBox();
            btt_ingresar = new Button();
            btt_Eliminar = new Button();
            btt_Mayormenor = new Button();
            btt_Menormayor = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 150);
            label1.Name = "label1";
            label1.Size = new Size(41, 17);
            label1.TabIndex = 0;
            label1.Text = "Valor:";
            // 
            // txt_Valor
            // 
            txt_Valor.Location = new Point(75, 142);
            txt_Valor.Name = "txt_Valor";
            txt_Valor.Size = new Size(133, 25);
            txt_Valor.TabIndex = 1;
            // 
            // LstDatos
            // 
            LstDatos.FormattingEnabled = true;
            LstDatos.ItemHeight = 17;
            LstDatos.Location = new Point(26, 195);
            LstDatos.Name = "LstDatos";
            LstDatos.Size = new Size(182, 191);
            LstDatos.TabIndex = 2;
            // 
            // btt_ingresar
            // 
            btt_ingresar.Location = new Point(225, 131);
            btt_ingresar.Name = "btt_ingresar";
            btt_ingresar.Size = new Size(81, 25);
            btt_ingresar.TabIndex = 3;
            btt_ingresar.Text = "Agregar";
            btt_ingresar.UseVisualStyleBackColor = true;
            btt_ingresar.Click += btt_ingresar_Click;
            // 
            // btt_Eliminar
            // 
            btt_Eliminar.Location = new Point(225, 162);
            btt_Eliminar.Name = "btt_Eliminar";
            btt_Eliminar.Size = new Size(81, 25);
            btt_Eliminar.TabIndex = 4;
            btt_Eliminar.Text = "Eliminar";
            btt_Eliminar.UseVisualStyleBackColor = true;
            btt_Eliminar.Click += btt_Eliminar_Click;
            // 
            // btt_Mayormenor
            // 
            btt_Mayormenor.Location = new Point(230, 274);
            btt_Mayormenor.Name = "btt_Mayormenor";
            btt_Mayormenor.Size = new Size(112, 25);
            btt_Mayormenor.TabIndex = 5;
            btt_Mayormenor.Text = "Mayor a Menor";
            btt_Mayormenor.UseVisualStyleBackColor = true;
            btt_Mayormenor.Click += btt_Mayormenor_Click;
            // 
            // btt_Menormayor
            // 
            btt_Menormayor.Location = new Point(230, 314);
            btt_Menormayor.Name = "btt_Menormayor";
            btt_Menormayor.Size = new Size(112, 25);
            btt_Menormayor.TabIndex = 6;
            btt_Menormayor.Text = "Menor a Mayor";
            btt_Menormayor.UseVisualStyleBackColor = true;
            btt_Menormayor.Click += btt_Menormayor_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 245);
            label2.Name = "label2";
            label2.Size = new Size(60, 17);
            label2.TabIndex = 7;
            label2.Text = "Ordenar:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8461542F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(12, 41);
            label3.Name = "label3";
            label3.Size = new Size(318, 56);
            label3.TabIndex = 8;
            label3.Text = "Ingreso Manual y Ordenamiento\r\nAscendente y Descendente\r\n";
            // 
            // Ingreso_manual_y_Ordenamiento
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 461);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btt_Menormayor);
            Controls.Add(btt_Mayormenor);
            Controls.Add(btt_Eliminar);
            Controls.Add(btt_ingresar);
            Controls.Add(LstDatos);
            Controls.Add(txt_Valor);
            Controls.Add(label1);
            Name = "Ingreso_manual_y_Ordenamiento";
            Text = "Ingreso_manual_y_Ordenamiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Valor;
        private ListBox LstDatos;
        private Button btt_ingresar;
        private Button btt_Eliminar;
        private Button btt_Mayormenor;
        private Button btt_Menormayor;
        private Label label2;
        private Label label3;
    }
}