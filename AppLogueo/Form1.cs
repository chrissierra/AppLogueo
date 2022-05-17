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
    public partial class Form1 : Form
    {

        public int intentos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrarUsuario form_registro = new registrarUsuario();
            form_registro.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //autenticarUsuario
            UserLogica registrarUsuario = new UserLogica();
            Usuario nuevo_registro_usuario = new Usuario();
            nuevo_registro_usuario.user = textBoxUser.Text.ToString();
            nuevo_registro_usuario.password = textBoxPassword.Text.ToString();

            UserLogica ingreso_a_base_de_datos = new UserLogica();
            bool verificar_ingreso = ingreso_a_base_de_datos.autenticarUsuario(nuevo_registro_usuario);
            

            if (verificar_ingreso)
            {
                mensaje("Ingreso realizado con éxito");
                userArea formUserArea = new userArea(textBoxUser.Text.ToString());
                this.Hide();
                formUserArea.Show();

            }
            else
            {
                mensaje("Revisa tus credenciales. " + ingreso_a_base_de_datos.error);
                
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
