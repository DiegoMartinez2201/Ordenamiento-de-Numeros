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
    public partial class Ordenamiento_M_a_M : Form
    {
        public Ordenamiento_M_a_M()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los números del TextBox y convertirlos en un array de enteros
                int[] numeros = textBox1.Text
                                    .Split(',')
                                    .Select(int.Parse)
                                    .ToArray();

                // Llamar a la función para ordenar usando selección
                OrdenarPorSeleccion(numeros);

                // Mostrar los números ordenados en el Label
                label1.Text = "Números ordenados: " + string.Join(", ", numeros);
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si hay un problema
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Función de ordenamiento por selección
        private void OrdenarPorSeleccion(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIdx])
                    {
                        minIdx = j;
                    }
                }

                // Intercambiar el valor mínimo con el valor de la posición actual
                int temp = arr[minIdx];
                arr[minIdx] = arr[i];
                arr[i] = temp;
            }
        }
    }
    
}
