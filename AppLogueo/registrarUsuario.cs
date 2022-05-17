using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLogueo.Modelo;
using AppLogueo.Logica;
namespace AppLogueo
{
    public partial class registrarUsuario : Form
    {
        public registrarUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registrarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form_login = new Form1();
            form_login.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLogica registrarUsuario = new UserLogica();
            Usuario nuevo_registro_usuario = new Usuario();
            nuevo_registro_usuario.user = textoBoxRegistroUsuario.Text.ToString();
            bool largo_correcto = false;

            if(textoBoxRegistroPass1.Text.ToString().Length > 5 && textoBoxRegistroPass2.Text.ToString().Length > 5)
            {
                largo_correcto = true;
            }
            else
            {
                mensaje("Escribe bien la contraseña, debe ser igual en ambas casillas. Debe ser al menos de 6 caracteres");
            }

            if(largo_correcto && textoBoxRegistroPass1.Text.ToString() == textoBoxRegistroPass2.Text.ToString())
            {
                nuevo_registro_usuario.user = textoBoxRegistroUsuario.Text.ToString();
                nuevo_registro_usuario.password = textoBoxRegistroPass1.Text.ToString();
                UserLogica ingreso_a_base_de_datos = new UserLogica();
                bool verificar_ingreso = ingreso_a_base_de_datos.GuardarUsuario(nuevo_registro_usuario);

                if(verificar_ingreso)
                    mensaje("Usuario Ingresado Correctamente");
                if (!verificar_ingreso)
                    mensaje("Hubo error al guardar..." + ingreso_a_base_de_datos.error);
            }
            else
            {

                if(largo_correcto)
                    mensaje("Escribe bien la contraseña, debe ser igual en ambas casillas. Debe ser al menos de 6 caracteres");
                textoBoxRegistroPass1.Text = "";
                textoBoxRegistroPass2.Text = "";
            }
            
        }

        private void mensaje(string mensaje)
        {

                string caption = "Mensaje";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(mensaje, caption, buttons);

            
        }
    }
}
