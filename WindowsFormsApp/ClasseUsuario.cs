﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp {
    public class ClasseUsuario {

        private string email; 
        private string senha;

        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        

        
        public ClasseUsuario(string email, string senha) {
            Email = email;
            Senha = senha;
        }

        
        public ClasseUsuario() {

        }
       


    }
}
