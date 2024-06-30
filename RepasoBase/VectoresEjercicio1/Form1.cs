using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectoresEjercicio1
{
    public partial class Form1 : Form
    {
        #region 
        //a.1
        int[] vector = new int[1000];
        int contador = 0;

        //a.2
        void AgregarValor(int valor)
        {
            vector[contador] =valor;
            contador++;
        }

        //a.3
        void Ordenar()
        {
            for(int n=0; n<contador-1; n++)
            {
                for (int m = n+1; m < contador; m++)
                {
                    if (vector[n] < vector[m])
                    {
                        int aux = vector[n];
                        vector[n]=vector[m];
                        vector[m]=aux;
                    }
                }
            }
        }

        //a.4
        int Buscar(int valor) 
        {
            int idx = -1;
            int n=0;
            while (idx == -1 && n < contador)
            {
                if (vector[n] == valor)
                { 
                    idx = n;
                }
                n++;
            }
            return idx;
        }

        #endregion 

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //b.1
            int valor = Convert.ToInt32(textBox1.Text);

            //b.2
            AgregarValor(valor);

            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //d.1
            int valorABuscar=Convert.ToInt32(textBox2.Text);
            //d.2
            int idx = Buscar(valorABuscar);
            //d.3
            if (idx > -1)
            {
                textBox1.Text = vector[idx].ToString();
            }
            else 
            {
                MessageBox.Show("valor no encontrado");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //c.
            Ordenar();

            for (int n = 0; n < contador; n++)
            {
                listBox1.Items.Add(vector[n].ToString());
            }
        }
    }
}
