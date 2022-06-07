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
    public partial class Cad_Reservas : Form
    {
        public Cad_Reservas()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Reservas_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmarCadReserva_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(@"Data Source=DUKE\SQLEXPRESS01;Initial Catalog=reserva;Integrated Security=True");
            String sql = "insert into cad_reserva(id, nome, rg, data_entrada, data_saida, numero_quarto, tipo_quarto) values(@id, @nome, @rg, @data_entrada, @data_saida, @numero_quarto, @tipo_quarto)";
            Random numeroID = new Random();
            numeroID.Next();
            SqlCommand cm = new SqlCommand(sql, c);
            try
            {
                cm.Parameters.Add(new SqlParameter("@id", numeroID.Next()));
                cm.Parameters.Add(new SqlParameter("@nome", this.txtNomeCadReserva.Text));
                cm.Parameters.Add(new SqlParameter("@rg", this.txtRGCadReserva.Text));
                cm.Parameters.Add(new SqlParameter("@data_entrada", this.txtEntradaCadReserva.Text));
                cm.Parameters.Add(new SqlParameter("@data_saida", this.txtSaidaCadReserva.Text));
                cm.Parameters.Add(new SqlParameter("@numero_quarto", this.txtQuartoCadReserva.Text));
                cm.Parameters.Add(new SqlParameter("@tipo_quarto", this.txtTipoReserva.Text));
                c.Open();
                cm.ExecuteNonQuery();
                c.Close();
                MessageBox.Show("Reserva cadastrada com sucesso!");


            }
            catch (SqlException ex)
            {
                MessageBox.Show("erro no cadastro da reserva" + ex);
            }
        }

        private void Cad_Reservas_Load(object sender, EventArgs e)
        {
            
        }
    }
}
