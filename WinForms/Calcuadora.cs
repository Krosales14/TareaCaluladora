using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    class Calcuadora
    {
        public Calcuadora() {

        }

        public double Valor1 { get; set; }
        public double Valor2 { get; set; }


        public double Sumar() {

            return Valor1 + Valor2;

        }

        public double Restar()
        {

            return Valor1 - Valor2;

        }


        public double Multiplicar()
        {

            return Valor1 * Valor2;

        }

        public double Dividir()
        {

            return Valor1 / Valor2;

        }

    }
}
