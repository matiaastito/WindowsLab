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
    public partial class FrmCaso5 : Form
    {
        public FrmCaso5()
        {
            InitializeComponent();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            string nombreUsuario = Interaction.InputBox("Ingrese el nombre");
            char sexoUsuario = char.Parse(Interaction.InputBox("Ingrese el sexo(M para masculino, F para Femenino)"));
            string tipoUsuario = Interaction.InputBox("Ingrese el tipo de usuario. Los tipos validos son Administrador," +
                "Estándar o Invitado");
            while (validarTipo(tipoUsuario) == 0)
            {
                tipoUsuario = Interaction.InputBox("Tipo invalido. Ingrese el tipo de usuario. " +
                    "Los tipos validos son Administrador,Estándar o Invitado");
            }
            while (validarSexo(Convert.ToString(sexoUsuario)) == 0)
            {
                sexoUsuario = char.Parse(Interaction.InputBox("Sexo invalido. Ingrese el sexo(M para masculino, F para Femenino"));
            } 
            MessageBox.Show("Usuario cargado con exito\n" + cargaUser(nombreUsuario, tipoUsuario, Convert.ToString(sexoUsuario)));


        }

        private int validarTipo(string tUsuario)
        {
            int flag = 0;
            tUsuario = tUsuario.ToUpper();
            if (string.Compare(tUsuario, "ADMINISTRADOR") ==0 || string.Compare(tUsuario, "ESTÁNDAR") == 0 || 
                string.Compare(tUsuario, "INVITADO") == 0){
                flag = 1;
            }
            return flag;
        } 

        private int validarSexo(string sUsuario)
        {
            int flag = 0;
            sUsuario = sUsuario.ToUpper();
            if (string.Compare(sUsuario, "F") == 0 || string.Compare(sUsuario, "M") == 0)
            {
                flag = 1;
            }
            
            return flag;
        }

        private string cargaUser (string nUsuario, string tUsuario, string sUsuario)
        {
            string newUser = "";
            newUser = "Usuario: " + nUsuario + "\nSexo: " + sUsuario + "\nRol: " + tUsuario;
            return newUser;
        }
    }
}
