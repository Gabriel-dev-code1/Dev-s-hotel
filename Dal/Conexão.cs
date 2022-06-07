using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PIM_Hotel.Dal
{
    class Conexão
    {
        SqlConnection con = new SqlConnection();
        public Conexão()
        {
            con.ConnectionString = @"Data Source=DUKE\SQLEXPRESS01;Initial Catalog=cad_log;Integrated Security=True";
        }
        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }
    }
}
