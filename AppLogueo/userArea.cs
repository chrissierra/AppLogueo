using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLogueo
{
    public partial class userArea : Form
    {


        public userArea(string NombreUsuario)
        {
            InitializeComponent();
            labelUsuarioLogueadoBienvenida.Text = NombreUsuario;
        }

        private void userArea_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
