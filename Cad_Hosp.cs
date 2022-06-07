using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PIM_Hotel
{
    public partial class Cad_Hosp : Form
    {
        public Cad_Hosp()
        {
            InitializeComponent();
        }

        private void txtCpfHosp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmarCadHosp_Click(object sender, EventArgs e)
        {
            //conexão banco de dados sql
            SqlConnection cn = new SqlConnection(@"Data Source=DUKE\SQLEXPRESS01;Initial Catalog=hotel;Integrated Security=True");
            
            String sql = "INSERT INTO dbo.cad_hosp(id, nome, data_nasc, telefone, RG, email) VALUES(@id, @nome, @data_nasc, @telefone, @RG, @email)";
            Random numeroId = new Random(); 
            numeroId.Next();
            SqlCommand c = new SqlCommand(sql, cn);

            try
            {
                
                c.Parameters.Add(new SqlParameter("@id", numeroId.Next()));
                c.Parameters.Add(new SqlParameter("@nome", this.txtFullnameCadHosp.Text));
                c.Parameters.Add(new SqlParameter("@data_nasc", this.txtDnascCadHosp.Text));
                c.Parameters.Add(new SqlParameter("@telefone", this.txtTelefoneCadHosp.Text));
                c.Parameters.Add(new SqlParameter("@RG", this.txtRGCadHosp.Text));
                c.Parameters.Add(new SqlParameter("@email", this.txtEmailCadHosp.Text));
                cn.Open();
                c.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Ocorreu erro: " + ex);
            }
        }

        private void Cad_Hosp_Load(object sender, EventArgs e)
        {

        }
    }
}
