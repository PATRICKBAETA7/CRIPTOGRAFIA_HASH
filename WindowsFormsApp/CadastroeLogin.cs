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

        
        private void Agenda_Load(object sender, EventArgs e) {

            //Método do projeto do período passado 2020/1. Tentei remover, 
            //mas dá erro no Form. Como quanto mais se mexe mais dá problema eu deixei quieto. kkkkkkkkkk
            
        }

        private void tbSenha_Leave(object sender, EventArgs e) {
            //Método do projeto do text box que excluí. Tentei remover, 
            //mas dá erro no Form. Como quanto mais se mexe mais dá problema eu deixei quieto. kkkkkkkkkk

        }



        private void tbEmail_Leave(object sender, EventArgs e) {
            //Método do projeto do text box que excluí. Tentei remover, 
            //mas dá erro no Form. Como quanto mais se mexe mais dá problema eu deixei quieto. kkkkkkkkkk
        }



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
            bool VerificaSenha;
            bool VerificaEmail;

            List<ClasseUsuario> UsuariosRegistros = ManipulaLogin.Manipulacao.SelecionarRegistros();
            ContaLogado FormLogado = new ContaLogado();
            CadastroeLogin FormCadastroLogin = new CadastroeLogin();

            for (int contador = 0; contador < UsuariosRegistros.Count; contador++)
            {

                ClasseHash hash = new ClasseHash(SHA512.Create());
                
                VerificaSenha = hash.VerificarSenha(tbSenhaDigitada.Text, UsuariosRegistros[contador].Senha);
                VerificaEmail = hash.VerificarEmail(tbEmail.Text,UsuariosRegistros[contador].Email);


                if (VerificaSenha == true && VerificaEmail == true)
                {   
                    tbEmail.Text = "";
                    tbSenhaDigitada.Text = "";
                    FormLogado.Show();
                    break;
                }
                else
                {
                    MessageBox.Show("Senha ou email Inválido!");
                    tbEmail.Text = "";
                    tbSenhaDigitada.Text = "";
                    break;
                }





            }

            



        }
    }
}
