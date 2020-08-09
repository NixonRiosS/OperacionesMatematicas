using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperacionesMatematicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sumar_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txt_numero1.Text);
            double numero2 = double.Parse(txt_numero2.Text);
            double suma = 0;

            suma = numero1 + numero2;

            lbl_resultado.Text = Convert.ToString(String.Format("{0:n0}", suma));
         }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_numero1.Text = String.Empty;
            txt_numero2.Text = String.Empty;
            lbl_resultado.Text = "0";
            txt_numero1.Focus();
        }

        private void btn_restar_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txt_numero1.Text);
            double numero2 = double.Parse(txt_numero2.Text);
            double resta = 0;

            resta = numero1 - numero2;

            lbl_resultado.Text = Convert.ToString(String.Format("{0:n0}", resta));
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txt_numero1.Text);
            double numero2 = double.Parse(txt_numero2.Text);
            double multiplicar = 0;

            multiplicar = numero1 * numero2;

            lbl_resultado.Text = Convert.ToString(String.Format("{0:n0}", multiplicar));
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txt_numero1.Text);
            double numero2 = double.Parse(txt_numero2.Text);
            double dividir = 0;

            dividir = numero1 / numero2;

            lbl_resultado.Text = Convert.ToString(String.Format("{0:n0}", dividir));
        }
    }
}
