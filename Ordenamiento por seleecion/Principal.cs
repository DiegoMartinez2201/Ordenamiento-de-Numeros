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
    }
}
