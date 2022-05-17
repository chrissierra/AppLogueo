using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using AppLogueo.Modelo;
using System.Data.SQLite;
namespace AppLogueo.Logica
{
    public class UserLogica
    {

        private static string cadena = ConfigurationManager.ConnectionStrings["nombreDb"].ConnectionString;
        public string error = "";
        public bool usuario_encontrado = true;
        public bool clave_erronea = false;
        private static UserLogica _instancia = null;

        public UserLogica()
        {

        }

        public static UserLogica Instancia
        {
            get
            {
                if(_instancia == null)
                {
                    _instancia = new UserLogica();
                }

                return _instancia;
            }
        }

        public bool GuardarUsuario(Usuario obj)
        {
            bool respuesta = true;

            using(SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "insert into usuarios(user, password,bloqueado,intentos) values (@user, @password,@bloqueado,@intentos)";
                int valor = 0;
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@user", obj.user));
                cmd.Parameters.Add(new SQLiteParameter("@password", obj.password));
                cmd.Parameters.Add(new SQLiteParameter("@bloqueado", valor));
                cmd.Parameters.Add(new SQLiteParameter("@intentos", valor));
                cmd.CommandType = System.Data.CommandType.Text;
                try
                {
                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        respuesta = false;
                    }
                }catch(Exception e)
                {
                    this.error = e.Message;
                    respuesta = false;
                }


            }


            return respuesta;

        }

        public bool autenticarUsuario(Usuario obj)
        {
            bool respuesta = false;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "select * from usuarios where user=@user";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@user", obj.user));
                cmd.CommandType = System.Data.CommandType.Text;



                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    /*
                    if (!dr.HasRows)
                    {
                        this.usuario_encontrado = false;
                        return false;
                    }
                       */ 

                    while (dr.Read())
                    {

                        if (Int32.Parse(dr["intentos"].ToString()) > 4)
                        {
                            this.error = "USUARIO CUENTA BLOQUEADA";
                            updatebloqueoEstatus(conexion, obj.user);
                            return false;
                        }
                        if(dr["password"].ToString() == obj.password){
                            this.updateIntentos(conexion, -1, obj.user);
                            return true;

                        }
                        else
                        {

                            this.clave_erronea = true;

                            this.updateIntentos(conexion, Int32.Parse(dr["intentos"].ToString()), obj.user);


                            return false;
                            
                        }
                    }
                }

            }


            return respuesta;
        }

        private bool updateIntentos(SQLiteConnection conexion, int intentos, string usuario)
        {


            int intentos_a_ingresar = intentos + 1;
                string query = "update usuarios set intentos = @intentos where user=@user";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@user", usuario));
                cmd.Parameters.Add(new SQLiteParameter("@intentos", intentos_a_ingresar));
                cmd.CommandType = System.Data.CommandType.Text;


                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        return true;
                    }
            return true;
        }

        private bool updatebloqueoEstatus(SQLiteConnection conexion, string usuario)
        {

            string query = "update usuarios set bloqueado = @bloqueado where user=@user";
            SQLiteCommand cmd = new SQLiteCommand(query, conexion);
            cmd.Parameters.Add(new SQLiteParameter("@user", usuario));
            cmd.Parameters.Add(new SQLiteParameter("@bloqueado", 1));
            cmd.CommandType = System.Data.CommandType.Text;


            if (cmd.ExecuteNonQuery() < 1)
            {
                return true;
            }
            return true;
        }

    }
}
