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
    public partial class FrmCaso3 : Form
    {
        public FrmCaso3()
        {
            InitializeComponent();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int nEntero = int.Parse(Interaction.InputBox("Ingrese un numero entero"));
            int nTabla = int.Parse(Interaction.InputBox("Ingrese el numero entero hasta donde quiere saber"));
            multiplicar(nEntero,nTabla);

        }

        private void multiplicar (int nEntero, int nTabla)
        {
            int[] arrayResultado = new int[nTabla];
            int mult = 1;
            for (int i = 0; i < nTabla; i++)
            {
                arrayResultado[i] = nEntero * mult;
                mult++;
            }
            mostrarTabla(arrayResultado);
        }

        private void mostrarTabla (int[] arrayResultado)
        {
            for (int i = 0; i < arrayResultado.Length; i++)
            {
                MessageBox.Show(Convert.ToString(arrayResultado[i]));
            }
        }
    }
}
