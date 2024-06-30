using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalEjercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            if (f2.ShowDialog() == DialogResult.OK)
            {
                int numero=Convert.ToInt32(f2.textBox1_public.Text);
                string texto = f2.textBox2_public.Text;
                bool Aprobado = f2.checkBox1.Checked;

                string condicion = "No";
                if (Aprobado)
                    condicion = "Si";

                listBox1.Items.Add($"{numero} - {texto} - {condicion}");

            }
        }
    }
}
