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
    public partial class SumaDeLosNumeros : Form
    {

        // Lista para almacenar los números ingresados
        private List<int> numeros = new List<int>();
        public SumaDeLosNumeros()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Verificar si el texto es un número válido
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                // Agregar número a la lista
                numeros.Add(numero);
                // Mostrar el número en el ListBox
                lstNumeros.Items.Add(numero);
                // Limpiar el TextBox
                txtNumero.Clear();
            }
            else
            {
                MessageBox.Show("Por favor ingresa un número válido.");
            }
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (numeros.Count > 0)
            {
                // Sumar los números de la lista
                int suma = 0;
                foreach (int numero in numeros)
                {
                    suma += numero;
                }

                // Mostrar el resultado de la suma
                MessageBox.Show("La suma de los números es: " + suma);

                // Limpiar la lista y el ListBox
                numeros.Clear();
                lstNumeros.Items.Clear();
            }
            else
            {
                MessageBox.Show("No hay números para sumar.");
            }
        }
    }
}
