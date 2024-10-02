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
    public partial class Ingreso_manual_y_Ordenamiento : Form
    {
        public Ingreso_manual_y_Ordenamiento()
        {
            InitializeComponent();
        }

        private void btt_ingresar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_Valor.Text, out int valor))
            {
                LstDatos.Items.Add(valor);
                txt_Valor.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido.");
            }
        }

        private void btt_Eliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_Valor.Text, out int valor))
            {
                bool encontrado = false;

                // Buscar y eliminar el valor en el ListBox
                for (int i = 0; i < LstDatos.Items.Count; i++)
                {
                    if ((int)LstDatos.Items[i] == valor)
                    {
                        LstDatos.Items.RemoveAt(i);
                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)
                {
                    MessageBox.Show("El valor no se encuentra en la lista.");
                }
                else
                {
                    txt_Valor.Clear();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido.");
            }
        }
        private void OrdenarLista(bool descendente)
        {
            // Convertir los items del ListBox a un array de enteros
            int[] numeros = new int[LstDatos.Items.Count];
            for (int i = 0; i < LstDatos.Items.Count; i++)
            {
                numeros[i] = (int)LstDatos.Items[i];
            }

            // Ordenar el array
            if (descendente)
            {
                Array.Sort(numeros);
                Array.Reverse(numeros);
            }
            else
            {
                Array.Sort(numeros);
            }

            // Volver a agregar los elementos ordenados al ListBox
            LstDatos.Items.Clear();
            foreach (var num in numeros)
            {
                LstDatos.Items.Add(num);
            }
        }

        private void btt_Mayormenor_Click(object sender, EventArgs e)
        {
            OrdenarLista(descendente: true);
        }

        private void btt_Menormayor_Click(object sender, EventArgs e)
        {
            OrdenarLista(descendente: false);
        }
    }
}
