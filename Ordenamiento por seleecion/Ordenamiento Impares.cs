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
    public partial class Ordenamiento_Impares : Form
    {
        int[] numerosAleatorios = new int[10];

        public Ordenamiento_Impares()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int[] numerosAleatorios = new int[10];

            for (int i = 0; i < 10; i++)
            {
                numerosAleatorios[i] = random.Next(1, 101);
            }

            txtArray.Text = string.Join(" - ", numerosAleatorios);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            string textoA = txtArray.Text;

            string[] numeros = textoA.Split(' ');

            StringBuilder impares = new StringBuilder();

            foreach (string numStr in numeros)
            {
                if (int.TryParse(numStr, out int num))
                {
                    if (num % 2 != 0)
                    {
                        impares.Append(num).Append(" - ");
                    }
                }
            }

            txtArrayOrdenado.Text = impares.ToString().Trim();
        }
    }
}
