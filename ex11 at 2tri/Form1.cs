using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex11_at_2tri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double P, A;

                P = Convert.ToDouble(txt1.Text);
                A = Convert.ToDouble(txt2.Text);
            if (P >= 90 && A >= 5)
            {
                MessageBox.Show("O seu Caminhão está impedido de passar pela ponte Pedrinho do Mar");
            }

            else if (P > 100 && A > 10)
            {
                MessageBox.Show("O seu Caminhão está impedido de passar pela ponte Pedrinho do Mar e pela ponte Maria Padilha");
            }

            else if (P > 110 && A > 15)
            {
                MessageBox.Show("O seu Caminhão está impedido de passar pela ponte Pedrinho do Mar, pela ponte Maria Padilha e Pela Ponte Tiriri");
            }

            else if (P <= 89 && A <= 4)
            {
                MessageBox.Show("O seu Caminhão não está impedido de passar por nehuma Ponte");
            }
        }
    }
}
