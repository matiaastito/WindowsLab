using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsLab
{
    public partial class FrmCaso2 : Form
    {
        public FrmCaso2()
        {
            InitializeComponent();
        }

        private void btnIngresoEdad_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(Interaction.InputBox("Ingrese su edad (debe ser mayor a 0)"));
            string respuesta = validadEdad(edad);
            MessageBox.Show(respuesta);

        }

        private string validadEdad (int edad)
        {
            if (edad <=  0)
            {
                return "ERROR";
            }
            else if(edad < 18)
            {
                return "Es menor de edad";
            }
            else if (edad < 60)
            {
                return "Es mayor de edad";
            }
            else
            {
                return "Es un adulto mayor";
            }
        }
    }
}
