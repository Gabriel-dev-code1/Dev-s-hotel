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
    public partial class Cad_Conta : Form
    {
        public Cad_Conta()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmcadFunc_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem=controle.cadastrar(txtEmailConta.Text, txtSenhaConta.Text, txtconfSenhaConta.Text);
            if(controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro");
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
