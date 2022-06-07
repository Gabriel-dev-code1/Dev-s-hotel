using PIM_Hotel.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_Hotel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void llblCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cad_Conta cad = new Cad_Conta();
            cad.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtLogin.Text, txtSenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("logado com sucesso!");
                    Menu menu = new Menu();
                    menu.Show();
                    
                }
                else
                {
                    MessageBox.Show("erro!");
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
