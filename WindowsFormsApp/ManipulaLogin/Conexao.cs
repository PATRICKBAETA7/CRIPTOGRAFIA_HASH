﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp.ManipulaLogin {
    public class Conexao {

        public static SqlConnection Conectar(){
            
            string conexao = @"Data Source=DESKTOP-9G4P5JV\SQLEXPRESS;Initial Catalog=login_hash; Integrated Security=True";
            SqlConnection connection = new SqlConnection(conexao);
            connection.Open();
            return connection;
        }




    }
}
