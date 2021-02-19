using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int primeirovalor = 0;
            int segundovalor = 0;
            int resultado = 0;
            primeirovalor = int.Parse(campo1.Text);
            segundovalor = int.Parse(textBox2.Text);
            if (radiomultiplicar.Checked)
            {
                multiplicacao m = new multiplicacao();
                resultado = m.Multiplicar2numeros(primeirovalor, segundovalor);
                MessageBox.Show("o resultado da multiplicacao é .." + resultado);
            }
            else if (radiosomar.Checked)
            {

            }
        
            

       
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
