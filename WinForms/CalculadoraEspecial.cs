using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class CalculadoraEspecial : Form
    {
        public CalculadoraEspecial()
        {
            InitializeComponent();
        }

        public String Valores { get; set; }

        public void Calcular(String Valores) {

            if (txtOperacion.Text.Contains("+"))
            {
                
                Calcuadora objCalculadora = new Calcuadora();
                string[] values = txtOperacion.Text.Split('+');
                objCalculadora.Valor1 = Convert.ToDouble(values[0]);
                objCalculadora.Valor2 = Convert.ToDouble(values[1]);
                txtOperacion.Text = objCalculadora.Sumar().ToString();
            }
            else if (txtOperacion.Text.Contains("-"))
            {
                
                Calcuadora objCalculadora = new Calcuadora();
                string[] values = txtOperacion.Text.Split('-');
                objCalculadora.Valor1 = Convert.ToDouble(values[0]);
                objCalculadora.Valor2 = Convert.ToDouble(values[1]);
                txtOperacion.Text = objCalculadora.Restar().ToString();
            }
            else if (txtOperacion.Text.Contains("/")) {
                
                Calcuadora objCalculadora = new Calcuadora();
                string[] values = txtOperacion.Text.Split('/');
                objCalculadora.Valor1 = Convert.ToDouble(values[0]);
                objCalculadora.Valor2 = Convert.ToDouble(values[1]);
                txtOperacion.Text = objCalculadora.Dividir().ToString();

            } else if (txtOperacion.Text.Contains("*")){
                
                Calcuadora objCalculadora = new Calcuadora();
                string[] values = txtOperacion.Text.Split('*');
                objCalculadora.Valor1 = Convert.ToDouble(values[0]);
                objCalculadora.Valor2 = Convert.ToDouble(values[1]);
                txtOperacion.Text = objCalculadora.Multiplicar().ToString();
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            this.txtOperacion.Text = String.Concat(txtOperacion.Text, btnSeven.Text);
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            this.txtOperacion.Text = String.Concat(txtOperacion.Text, btnEight.Text);
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            this.txtOperacion.Text = String.Concat(txtOperacion.Text, btnNine.Text);
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            this.txtOperacion.Text = String.Concat(txtOperacion.Text, btnFour.Text);
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            this.txtOperacion.Text = String.Concat(txtOperacion.Text, btnFive.Text);
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            this.txtOperacion.Text = String.Concat(txtOperacion.Text,  btnSix.Text);
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            this.txtOperacion.Text = String.Concat(txtOperacion.Text, btnOne.Text);
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            this.txtOperacion.Text = String.Concat(txtOperacion.Text, btnTwo.Text);
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            this.txtOperacion.Text = String.Concat(txtOperacion.Text, btnThree.Text);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (txtOperacion.Text.Contains("/"))
            {

            }
            else {
                this.txtOperacion.Text = String.Concat(txtOperacion.Text, btnDiv.Text);
            }
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            if (!txtOperacion.Text.Contains("*"))
            {
                txtOperacion.Text = String.Concat(txtOperacion.Text, btnStar.Text);
            }
           
        }

        private void btnSubstrac_Click(object sender, EventArgs e)
        {
            this.txtOperacion.Text = String.Concat(txtOperacion.Text, btnSubstrac.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!txtOperacion.Text.Contains("-")) {
                this.txtOperacion.Text = String.Concat(txtOperacion.Text, btnAdd.Text);
            }            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtOperacion.Text.Length > 0) {
                txtOperacion.Text = txtOperacion.Text.Substring(0, txtOperacion.Text.Length - 1);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOperacion.Clear();
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            this.txtOperacion.Text = String.Concat(txtOperacion.Text, btnCero.Text);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            this.Calcular(txtOperacion.Text);
        }
    }
}
