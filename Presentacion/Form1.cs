using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Datos;
using Entidades;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string strUsuario = txtUsuario.Text;
            string strPassword = txtPassword.Text;
            E_Usuario usuario = N_Usuario.login(strUsuario, strPassword);
            if (usuario != null && usuario.id > 0)
            {
                //login exitoso
                MessageBox.Show("¡Bienvenido, " + usuario.dsUsuario + "!", "Login Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Aqui puedes abrir el formulario principal de tu aplicacion
                this.Hide(); //Oculta el formulario de login
                FrmPrincipal formPrincipal = new FrmPrincipal(); //Asegurate de tener un formulario principal
                formPrincipal.usuario = usuario;
                formPrincipal.Show();
                            //this.Close(); //Cierra el formulario de login despues de cerrar el principal
            }
            else
            {
                //login fallido
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
