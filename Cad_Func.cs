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
    public partial class Cad_Func : Form
    {
        public Cad_Func()
        {
            InitializeComponent();
        }

        private void btnCadFunc_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DUKE\SQLEXPRESS01;Initial Catalog=cad_func;Integrated Security=True");
            string sql = "insert into func (id, nome, cpf, data_nasc, telefone, rg) values(@id, @nome, @cpf, @data_nasc, @telefone, @rg)";
            Random numeroId = new Random();
            numeroId.Next();
            SqlCommand cmd = new SqlCommand(sql, cn);
            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", numeroId.Next()));
                cmd.Parameters.Add(new SqlParameter("@nome", this.txtFullnameCadFunc.Text));
                cmd.Parameters.Add(new SqlParameter("@cpf", this.txtCpfcadFunc.Text));
                cmd.Parameters.Add(new SqlParameter("@data_nasc", this.txtDnascCadFunc.Text));
                cmd.Parameters.Add(new SqlParameter("@telefone", this.txtTelCadFunc.Text));
                cmd.Parameters.Add(new SqlParameter("@rg", this.txtRGCadFunc.Text));
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("cadastrado com sucesso!");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("houve um erro, tente novamente"+ ex);
            }
        }

        private void Cad_Func_Load(object sender, EventArgs e)
        {

        }
    }
}
