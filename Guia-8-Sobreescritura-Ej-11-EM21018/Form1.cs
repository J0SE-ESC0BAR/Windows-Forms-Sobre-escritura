using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_8_Sobreescritura_Ej_11_EM21018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //try validar los datos
            try
            {
                //switch para elejir la opccion 
                switch (cbFigura.Text)
                {
                    case "Cuadrado":
                        Fig4Lados cuadrado = new Fig4Lados();
                            tbResultado.Text = (cuadrado.Area(double.Parse(tbCL1.Text)).ToString());
                        break;
                    case "Rectangulo":
                        Fig4Lados retangulo = new Fig4Lados();

                            tbResultado.Text = (retangulo.Area(double.Parse(tbCL1.Text), double.Parse(tbCL2.Text)).ToString());
                        break;

                    case "Triangulo":
                        Fig3Lad triangulo = new Fig3Lad();
                        if (rbEquilatero.Checked)
                        {
                            tbResultado.Text = (triangulo.Area(double.Parse(tbTL1.Text))).ToString();
                        }
                        else if (rbIsosceles.Checked)
                        {
                            tbResultado.Text = (triangulo.Area(double.Parse(tbTL1.Text), double.Parse(tbTL2.Text))).ToString();
                        }
                        else
                        {
                            tbResultado.Text = (triangulo.Area(double.Parse(tbTL1.Text), double.Parse(tbTL2.Text), double.Parse(tbTL3.Text))).ToString();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                //mensaje de error
                MessageBox.Show($"Ingrese ingrese numeros \n\r Error espesifico: {ex.Message}","Error de datos");
            }
        }

        private void cbFigura_SelectedIndexChanged(object sender, EventArgs e)
        {   //ocultar o mostrar menu de ingreso de datos segun lo que alla eljeido
            if (cbFigura.Text=="Cuadrado")
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
                tbCL2.Visible = false;
            }
            else if (cbFigura.Text == "Rectangulo")
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
                tbCL2.Visible = true;
            }
            else if (cbFigura.Text == "Triangulo")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
            }
        }

        private void Isosceles_CheckedChanged(object sender, EventArgs e)
        {   //muestra la entrada de datos segun el triangulo
            tbTL1.Text = "";
            tbTL2.Text = "";
            tbTL3.Text = "";
            if (rbIsosceles.Checked)
            {
                tbTL1.Visible = true;
                tbTL2.Visible = true; 
                tbTL3.Visible = false;
            }
            else if (rbEscaleno.Checked)
            {
                tbTL1.Visible = true;
                tbTL2.Visible = true;
                tbTL3.Visible = true;
            }
            else if (rbEquilatero.Checked)
            {
                tbTL1.Visible = true;
                tbTL2.Visible = false;
                tbTL3.Visible = false;
            }
        }

        private void rbEquilatero_CheckedChanged(object sender, EventArgs e)
        {
            //muestra la entrada de datos segun el triangulo
            tbTL1.Text = "";
            tbTL2.Text = "";
            tbTL3.Text = "";
            if (rbIsosceles.Checked)
            {
                tbTL1.Visible = true;
                tbTL2.Visible = true;
                tbTL3.Visible = false;
            }
            else if (rbEscaleno.Checked)
            {
                tbTL1.Visible = true;
                tbTL2.Visible = true;
                tbTL3.Visible = true;
            }
            else if (rbEquilatero.Checked)
            {
                tbTL1.Visible = true;
                tbTL2.Visible = false;
                tbTL3.Visible = false;
            }
        }
    }
}
