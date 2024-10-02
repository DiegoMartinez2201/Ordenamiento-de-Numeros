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
    public partial class Ordenamiento_Pares : Form
    {
        public Ordenamiento_Pares()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Obtener los números desde el TextBox y dividirlos por comas
            string[] numerosTexto = txtNumeros.Text.Split(',');

            // Convertir los números de texto a enteros, filtrar los pares y ordenarlos
            var numerosParesOrdenados = numerosTexto
                .Select(n => int.Parse(n.Trim()))  // Convertir a int
                .Where(n => n % 2 == 0)           // Filtrar pares
                .OrderBy(n => n)                  // Ordenar
                .ToList();

            // Limpiar el ListBox antes de agregar los pares ordenados
            listBoxPares.Items.Clear();

            // Mostrar los números pares ordenados en el ListBox
            foreach (var numero in numerosParesOrdenados)
            {
                listBoxPares.Items.Add(numero);
            }
        }
    }
}
