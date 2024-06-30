using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectoresEjercicio2
{
    public partial class Form1 : Form
    {
        #region 
        //a.1
        int[] vector1 = new int[1000];
        int[] vector2 = new int[1000];
        int contador = 0;

        //a.2
        void AgregarValores(int valor1, int valor2)
        {
            vector1[contador] = valor1;
            vector2[contador] = valor2;
            contador++;
        }

        //a.3
        void Ordenar()
        {
            for (int n = 0; n < contador - 1; n++)
            {
                for (int m = n + 1; m < contador; m++)
                {
                    if (vector2[n] < vector2[m])
                    {
                        int aux1 = vector1[n];
                        vector1[n] = vector1[m];
                        vector1[m] = aux1;

                        int aux2 = vector2[n];
                        vector2[n] = vector2[m];
                        vector2[m] = aux2;
                    }
                }
            }
        }

        //a.4
        int Buscar(int valor)
        {
            int idx = -1;
            int n = 0;
            while (idx == -1 && n < contador)
            {
                if (vector1[n] == valor)
                {
                    idx = n;
                }
                n++;
            }
            return idx;
        }

        int[] copiaVector1 = new int[1000];
        int[] copiaVector2 = new int[1000];
        int copiaContador = 0;
        void Listar(int valor2)
        {
            copiaContador = 0;
            for (int n = 0; n < contador; n++)
            {
                if (vector2[n] == valor2)
                {
                    copiaVector1[copiaContador] = vector1[contador];
                    copiaVector2[copiaContador] = vector2[contador];
                    copiaContador++;
                }
            }
        }

        #endregion 

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //d.1
            int valorABuscar = Convert.ToInt32(textBox4.Text);
            //d.2
            int idx = Buscar(valorABuscar);
            //d.3
            if (idx > -1)
            {
                textBox1.Text = vector1[idx].ToString();
                textBox2.Text = vector2[idx].ToString();
            }
            else
            {
                MessageBox.Show("valor no encontrado");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //b.1
            int valor1 = Convert.ToInt32(textBox1.Text);
            int valor2 = Convert.ToInt32(textBox2.Text);

            //b.2
            AgregarValores(valor1,valor2);

            textBox1.Clear();
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //d.1
            int valor2 = Convert.ToInt32(textBox3.Text);

            //d.2
            Listar(valor2);

            //d.3
            listBox1.Items.Clear();
            for (int n = 0; n < copiaContador; n++)
            {
                listBox1.Items.Add(copiaVector1[n].ToString() + "-" + copiaVector2[n].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //c.
            Ordenar();

            listBox1.Items.Clear();
            for (int n = 0; n < contador; n++)
            {
                listBox1.Items.Add(vector1[n].ToString() + "-"+ vector2[n].ToString());
            }
        }
    }
}
