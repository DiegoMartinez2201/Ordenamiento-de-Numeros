using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenamiento_por_seleecion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnascendente_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();
        }

        private void btnimpares_Click(object sender, EventArgs e)
        {
            Ordenamiento_Impares form2 = new Ordenamiento_Impares();

            form2.Show();
        }

        private void btndescendente1_Click(object sender, EventArgs e)
        {
            Ordenamiento_de_Mayor_a_Menor form3 = new Ordenamiento_de_Mayor_a_Menor();

            form3.Show();
        }

        private void btnpares_Click(object sender, EventArgs e)
        {
            Ordenamiento_Pares form4 = new Ordenamiento_Pares();

            form4.Show();
        }

        private void btnmanual_Click(object sender, EventArgs e)
        {
            Ingreso_manual_y_Ordenamiento form5 = new Ingreso_manual_y_Ordenamiento();

            form5.Show();
        }
    }
}
