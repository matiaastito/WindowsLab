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
    public partial class FrmCaso1 : Form
    {
        public FrmCaso1()
        {
            InitializeComponent();
        }

        private void btnAreaRect_Click(object sender, EventArgs e)
        {
            decimal bRectangulo = decimal.Parse(Interaction.InputBox("Ingrese la base del Rectangulo:", "Carga datos"));
            decimal hRectangulo = decimal.Parse(Interaction.InputBox("Ingrese la altura del Rectangulo:", "Carga datos"));
            decimal area = 0;
            area = areaRectangulo(bRectangulo, hRectangulo);
            MessageBox.Show("El area del rectangulo de base " + bRectangulo + " y altura " + hRectangulo + " es " + area);
        }

        private decimal areaRectangulo (decimal bRec, decimal hRec) {

            return bRec * hRec;
        }
    }
 }

