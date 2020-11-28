using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp {
    public partial class CadastroeLogin : Form {


        

        public CadastroeLogin() {
            InitializeComponent();
            
        }

        

        List<ClasseUsuario> ListaUsuarios = new List<ClasseUsuario>();

        
       


        private void btCadastrar_Click(object sender, EventArgs e)
        {

            try {
                ClasseHash hash = new ClasseHash(SHA512.Create());
                string SenhaEncrip = hash.CriptografarSenha(tbSenhaDigitada.Text);


                ManipulaLogin.Manipulacao.InserirRegistro(tbEmail.Text, SenhaEncrip);

                MessageBox.Show("Cadastrado com Sucesso! Faça Login.");

            }
            catch (Exception)
            {
                MessageBox.Show("Usuário Já existe.");
                tbEmail.Text = "";
                tbSenhaDigitada.Text = "";

                // Campo Email configurado como Unique no banco de dados. Não tem como cadastrar o mesmo email mais de uma vez

            }
                
            

            
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            

            
            List<ClasseUsuario> UsuariosRegistros = ManipulaLogin.Manipulacao.SelecionarRegistros();
            
            

            for (int contador = 0; contador < UsuariosRegistros.Count; contador++)
            {
                bool VerificaSenha;
                bool VerificaEmail;
                ClasseHash hash = new ClasseHash(SHA512.Create());
                
                VerificaSenha = hash.VerificarSenha(tbSenhaDigitada.Text, UsuariosRegistros[contador].Senha);
                
                if(tbEmail.Text == UsuariosRegistros[contador].Email)
                {
                    VerificaEmail = true;
                }
                else
                {
                    VerificaEmail = false;
                }

                if (VerificaSenha == true && VerificaEmail == true)
                {
                    tbEmail.Text = "";
                    tbSenhaDigitada.Text = "";


                    this.Hide();
                    ContaLogado FormLogado = new ContaLogado();
                    FormLogado.Show();
                    break;
                }
                else
                {
                    MessageBox.Show("Senha ou email inválidos!");
                    tbEmail.Text = "";
                    tbSenhaDigitada.Text = "";
                    ContaLogado FormLogado = new ContaLogado();
                    FormLogado.Hide();
                    break;
                }

             
            }

            
        }

        private void btVoltarPrincipal_Click(object sender, EventArgs e)
        {
            Principal FormPrincipal = new Principal();
            FormPrincipal.Show();
            this.Hide();
        }

        private void btEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
