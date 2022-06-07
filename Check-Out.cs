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
    public partial class Check_Out : Form
    {
        public Check_Out()
        {
            InitializeComponent();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

        }

        private void lblEstadoOut_Click(object sender, EventArgs e)
        {

        }

        private void lblRGOut_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltarOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSituaçaoOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSaidaOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEntradaOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuartoOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReservaOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSaidaOut_Click(object sender, EventArgs e)
        {

        }

        private void lblEntradaOut_Click(object sender, EventArgs e)
        {

        }

        private void lblsituaçãoOut_Click(object sender, EventArgs e)
        {

        }

        private void lblQuartoOut_Click(object sender, EventArgs e)
        {

        }

        private void lblReservaOut_Click(object sender, EventArgs e)
        {

        }

        private void lblReservaIN_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefoneOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmailOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCepOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRGOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTelefoneOut_Click(object sender, EventArgs e)
        {

        }

        private void lblCepOut_Click(object sender, EventArgs e)
        {

        }

        private void lblEmailOut_Click(object sender, EventArgs e)
        {

        }

        private void lblNomeOut_Click(object sender, EventArgs e)
        {

        }

        private void lblinformações_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarOut_Click(object sender, EventArgs e)
        {

        }

        private void lblBuscaOut_Click(object sender, EventArgs e)
        {

        }

        private void txtRGBuscaOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRG_Out_Click(object sender, EventArgs e)
        {

        }

        private void Check_Out_Load(object sender, EventArgs e)
        {
            
            this.cad_reservaTableAdapter.Fill(this.reservaDataSet1.cad_reserva);
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        
        private void btnConfirmarOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Check-out feio com sucesso");
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
