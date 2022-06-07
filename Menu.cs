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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void checkINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Check_In check = new Check_In();
            check.Show();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Check_Out check = new Check_Out();
            check.Show();
        }

        private void menures_Click(object sender, EventArgs e)
        {
            Cad_Reservas reserv = new Cad_Reservas();
            reserv.Show();
        }

        private void cadastroHóspedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cad_Hosp hospe = new Cad_Hosp();
            hospe.Show();
        }

        private void menuhosp_Click(object sender, EventArgs e)
        {
            Hóspedes hosp = new Hóspedes();
            hosp.Show();
        }

        private void cadastroFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cad_Func funcionario = new Cad_Func();
            funcionario.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionários func = new Funcionários();
            func.Show();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservas rese = new Reservas();
            rese.Show();
        }

        

        private void btnFecharProg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Login log=new Login();
            log.Show();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio rel = new Relatorio();
            rel.Show();
        }
    }
}
