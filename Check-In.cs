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
    public partial class Check_In : Form
    {
        public Check_In()
        {
            InitializeComponent();
        }

        private void Check_In_Load(object sender, EventArgs e)
        {
            
            this.cad_reservaTableAdapter1.Fill(this.reservaDataSet3.cad_reserva);
           
           

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFecharIn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCheckIN_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("check-in feito com sucesso!");
            
        }

        private void btnBuscarIn_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

       
          
        
    }
}
