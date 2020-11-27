using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.ManipulaLogin {
    public class Manipulacao {

        

        public static void InserirRegistro(string email, string senha)
        {

            SqlCommand command = new SqlCommand();
            command.Connection = Conexao.Conectar();
            command.CommandText = $"INSERT INTO usuario VALUES (@email,@senha)";
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@senha", senha);

            command.ExecuteNonQuery();

        }
        public static List<ClasseUsuario> SelecionarRegistros()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Conexao.Conectar();
            command.CommandText = "SELECT * FROM usuario";
            SqlDataReader linhasRegistros = command.ExecuteReader();

            List<ClasseUsuario> Usuarios = new List<ClasseUsuario>();
            ClasseUsuario usuario;

            while (linhasRegistros.Read())
            {
                var email = linhasRegistros[1].ToString();
                var senha = linhasRegistros[2].ToString();
                

                usuario = new ClasseUsuario(email, senha);
                Usuarios.Add(usuario);
            }

            

            return Usuarios;
        }

    }
}
