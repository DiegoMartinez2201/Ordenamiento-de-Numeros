namespace Ordenamiento_por_seleecion
{
    partial class Principal
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
            btndescendente1 = new Button();
            btnascendente = new Button();
            btnpares = new Button();
            btnimpares = new Button();
            btnmanual = new Button();
            btnsuma = new Button();
            SuspendLayout();
            // 
            // btndescendente1
            // 
            btndescendente1.Location = new Point(166, 87);
            btndescendente1.Name = "btndescendente1";
            btndescendente1.Size = new Size(115, 50);
            btndescendente1.TabIndex = 0;
            btndescendente1.Text = "ordenar de mayor a menor \n";
            btndescendente1.UseVisualStyleBackColor = true;
            btndescendente1.Click += btndescendente1_Click;
            // 
            // btnascendente
            // 
            btnascendente.Location = new Point(358, 87);
            btnascendente.Name = "btnascendente";
            btnascendente.Size = new Size(113, 50);
            btnascendente.TabIndex = 1;
            btnascendente.Text = "ordenar de menor a mayor \n";
            btnascendente.UseVisualStyleBackColor = true;
            btnascendente.Click += btnascendente_Click;
            // 
            // btnpares
            // 
            btnpares.Location = new Point(166, 165);
            btnpares.Name = "btnpares";
            btnpares.Size = new Size(115, 50);
            btnpares.TabIndex = 0;
            btnpares.Text = "ordenar solo numero pares\n";
            btnpares.UseVisualStyleBackColor = true;
            btnpares.Click += btnpares_Click;
            // 
            // btnimpares
            // 
            btnimpares.Location = new Point(358, 165);
            btnimpares.Name = "btnimpares";
            btnimpares.Size = new Size(113, 50);
            btnimpares.TabIndex = 1;
            btnimpares.Text = "ordenar solo numero impares\n";
            btnimpares.UseVisualStyleBackColor = true;
            btnimpares.Click += btnimpares_Click;
            // 
            // btnmanual
            // 
            btnmanual.Location = new Point(157, 247);
            btnmanual.Name = "btnmanual";
            btnmanual.Size = new Size(124, 93);
            btnmanual.TabIndex = 0;
            btnmanual.Text = "ingresar de forma manual y ordenar los numero de mayor a menor\n";
            btnmanual.UseVisualStyleBackColor = true;
            btnmanual.Click += btnmanual_Click;
            // 
            // btnsuma
            // 
            btnsuma.Location = new Point(358, 247);
            btnsuma.Name = "btnsuma";
            btnsuma.Size = new Size(113, 50);
            btnsuma.TabIndex = 1;
            btnsuma.Text = "suma de todos los numeros";
            btnsuma.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(btnsuma);
            Controls.Add(btnmanual);
            Controls.Add(btnimpares);
            Controls.Add(btnpares);
            Controls.Add(btnascendente);
            Controls.Add(btndescendente1);
            Name = "Principal";
            Text = "Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btndescendente1;
        private Button btnascendente;
        private Button btnpares;
        private Button btnimpares;
        private Button btnmanual;
        private Button btnsuma;
    }
}