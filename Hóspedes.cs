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
    public partial class Hóspedes : Form
    {
        public Hóspedes()
        {
            InitializeComponent();
        }

        private void Hóspedes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'hotelDataSet2.cad_hosp'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_hospTableAdapter2.Fill(this.hotelDataSet2.cad_hosp);
            // TODO: esta linha de código carrega dados na tabela 'hotelDataSet1.cad_hosp'. Você pode movê-la ou removê-la conforme necessário.


            

        }

        private void btnFecharHospede_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
