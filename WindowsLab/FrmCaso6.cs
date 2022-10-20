using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsLab
{
    public partial class FrmCaso6 : Form
    {
        public FrmCaso6()
        {
            InitializeComponent();
        }

        private void btnInsertDatos_Click(object sender, EventArgs e)
        {
            string nombreCompleto = Interaction.InputBox("Ingrese su nombre completo", "Carga datos");
            DateTime fechaNacimiento = DateTime.Parse(Interaction.InputBox("Ingrese su fecha de nacimiento con formato dd/mm/yyyy"));
            imprimir(nombreCompleto);
            imprimir(nombreCompleto, fechaNacimiento);
        }

        private void imprimir (string nombreCompleto)
        {
            MessageBox.Show(nombreCompleto);               
        }

        private void imprimir (string nombreCompleto, DateTime fechaNacimiento)
        {
            int edad = calcularEdad(fechaNacimiento);
            MessageBox.Show("Nombre: " + nombreCompleto + "\nEdad: " + edad);
        }

        private int calcularEdad(DateTime fechaNacimiento) 
        {
            int edad = 0;
            DateTime fechaActual = DateTime.Today;
            edad = fechaActual.Year - fechaNacimiento.Year;
            return edad;
        }
    }
}
