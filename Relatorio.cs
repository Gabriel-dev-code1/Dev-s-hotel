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
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cad_funcDataSet1.func'. Você pode movê-la ou removê-la conforme necessário.
            this.funcTableAdapter.Fill(this.cad_funcDataSet1.func);
            // TODO: esta linha de código carrega dados na tabela 'reservaDataSet4.cad_reserva'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_reservaTableAdapter.Fill(this.reservaDataSet4.cad_reserva);

        }
    }
}
