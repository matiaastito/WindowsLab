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
    public partial class FrmCaso4 : Form
    {
        const double PI = 3.14;
        public FrmCaso4()
        {
            InitializeComponent();
        }

        private void btnCalcularArea_Click(object sender, EventArgs e)
        {
            decimal resultado = 0;
            
            MessageBox.Show("A continuacion se le pedira que ingrese un numero." +
                "\nSi desea calcular el area de un circulo, presione 1." +
                "\nSi desea calcular el area de un trapecio, presione 2." +
                "\nSi desea calcular el area de un rectangulo, presione 3" +
                "\nIngrese 0 para finalizar.");
            int opcArea = int.Parse(Interaction.InputBox("Ingrese un numero:"));
            switch (opcArea)
            {
                case 1:
                    resultado = (decimal)areaCirculo();
                    MessageBox.Show("El area del circulo es " + resultado);
                    break;
                case 2:
                    resultado = areaTrapecio();
                    MessageBox.Show("El area del trapecio es " + resultado);
                    break;
                case 3:
                    resultado = areaRectangulo();
                    MessageBox.Show("El area del rectangulo es " + resultado);
                    break;
                case 0:
                    break;
            }
        }

        private decimal areaRectangulo()
        {
            decimal bRectangulo = decimal.Parse(Interaction.InputBox("Ingrese la base del Rectangulo:", "Carga datos"));
            decimal hRectangulo = decimal.Parse(Interaction.InputBox("Ingrese la altura del Rectangulo:", "Carga datos"));
            return bRectangulo * hRectangulo;
        }

        private decimal areaTrapecio()
        {
            decimal bMenorTrapecio = decimal.Parse(Interaction.InputBox("Ingrese la base menor del Trapecio:", "Carga datos"));
            decimal bMayorTrapecio = decimal.Parse(Interaction.InputBox("Ingrese la base mayor del Trapecio:", "Carga datos"));
            decimal hTrapecio = decimal.Parse(Interaction.InputBox("Ingrese la altura del Trapecio:", "Carga datos"));
            return (bMayorTrapecio+bMenorTrapecio)*hTrapecio/2;
        }

        private double areaCirculo()
        {
            double rCirculo = double.Parse(Interaction.InputBox("Ingrese el Radio del Circulo:", "Carga datos"));
            return PI * rCirculo * rCirculo;
        }
    }
}
