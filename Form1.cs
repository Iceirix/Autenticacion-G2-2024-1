using System;
using System.Windows.Forms;
using BiblioUsuarios_G2_2024_1;
using System.Collections;

namespace Autenticacion_G2_2024_1
{
    public partial class Form1 : Form
    {
        private ArrayList usuarios;
        public Form1()
        {
            InitializeComponent();
            usuarios = new ArrayList();
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            usuarios.Add(new Usuario("Armando","*armando00"));
            usuarios.Add(new Usuario("Luis", "luis123"));
            usuarios.Add(new Usuario("Jorge", "contra7"));
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int c = 0;
            foreach (object usuario in usuarios)
            {
                Usuario miUsuario = (Usuario)usuario;
                if (txtbUser.Text == miUsuario.NomUsuario  && txtbPassword.Text ==miUsuario.Password)
                {
                    MessageBox.Show("Ingreso Correcto");
                    break;
                }
                else if(c == usuarios.Count-1)
                    MessageBox.Show("Usuario o contraseña incorrecto");
                }
                c++;
            }
        }
    }
}
