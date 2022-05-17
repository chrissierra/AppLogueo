using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogueo.Modelo
{
    public class Usuario
    {
        public int id { get; set; }
        public string user { get; set; }
        public string password { get; set; }

        public int intentos { get; set; }
        public int bloqueado { get; set; }

    }
}
