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
    public partial class Ordenamiento_de_Mayor_a_Menor : Form
    {
        public Ordenamiento_de_Mayor_a_Menor()
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

            // Dividir la cadena en un array de números
            string[] numeros = textoA.Split(' ');

            // Convertir a enteros, filtrar y ordenar de mayor a menor
            List<int> listaNumeros = new List<int>();

            foreach (string numStr in numeros)
            {
                if (int.TryParse(numStr, out int num))
                {
                    listaNumeros.Add(num); // Agregar todos los números
                }
            }

            // Ordenar los números de mayor a menor
            listaNumeros = listaNumeros.OrderByDescending(n => n).ToList();

            // Crear la cadena para mostrar los números
            StringBuilder resultado = new StringBuilder();
            foreach (int num in listaNumeros)
            {
                resultado.Append(num).Append(" - ");
            }

            // Mostrar el resultado en el TextBox
            txtArrayOrdenado.Text = resultado.ToString().Trim(' ', '-');
        }
    }
}
