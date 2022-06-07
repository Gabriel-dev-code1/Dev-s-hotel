using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_Hotel
{
    public partial class Funcionários : Form
    {
        public Funcionários()
        {
            InitializeComponent();
        }

        private void Funcionários_Load(object sender, EventArgs e)
        {
            
            
            // TODO: esta linha de código carrega dados na tabela 'cad_funcDataSet.func'. Você pode movê-la ou removê-la conforme necessário.
            this.funcTableAdapter.Fill(this.cad_funcDataSet.func);

        }

        private void btnBuscarFunc_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFecharFunc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
