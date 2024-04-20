using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private static Persona persona = new Persona();


        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            //Asignar valores a los atributos de la clase Programa
            persona.Apellidos = txtApellidos.Text;
            persona.Nombre = txtnombres.Text;
            persona.Edad = Convert.ToInt32(txtEdad.Text);
            MessageBox.Show("se registro correctamente el objeto persona");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            MessageBox.Show(persona.DevolverDatos());
        }
    }
}
