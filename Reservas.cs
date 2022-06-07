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
    public partial class Reservas : Form
    {
        public Reservas()
        {
            InitializeComponent();
        }

        private void Reservas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'reservaDataSet.cad_reserva'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_reservaTableAdapter.Fill(this.reservaDataSet.cad_reserva);

        }

        private void btnFecharReserva_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }
    }
}
