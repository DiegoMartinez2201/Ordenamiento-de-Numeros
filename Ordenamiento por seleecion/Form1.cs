using System;
namespace Ordenamiento_por_seleecion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] array;
        Random r = new Random();
        private void mostrar(TextBox txtArray, int[] m)
        {
            txtArray.Text = "";
            for (int i = 0; i < m.Length; i++)
            {
                if (i == array.Length - i)
                {
                    txtArray.Text += m[i];
                }
                else
                {
                    txtArray.Text += m[i] + " -  ";
                }
            }
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(1, 101);
            }
            mostrar(txtArray, array);
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            int menor = 0, posicion, auxiliar;
            for (int i = 0; i < array.Length; i++)
            {
                menor = array[i];
                posicion = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < menor)
                    {
                        menor = array[j];
                        posicion = j;
                    }
                }
                if (posicion != i)
                {
                    auxiliar = array[i];
                    array[i] = array[posicion];
                    array[posicion] = auxiliar;
                }
            }
            mostrar(txtArrayOrdenado, array);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}