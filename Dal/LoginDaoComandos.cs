using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_Hotel.Dal
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexão con = new Conexão();
        SqlDataReader dr;
        public bool verificarLogin(String login, string senha)
        {
            cmd.CommandText = "select *from logins where email= @login and senha= @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch(SqlException)
            {
                this.mensagem = "erro com banco de dados";
            }
            return tem;

        }
        public string cadastrar(string email, string senha, string confirmSenha)
        {
            tem = false;
            if (senha.Equals(confirmSenha))
            {
                cmd.CommandText = "insert into logins values(@email, @senha)";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);
                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "cadastrado com sucesso";
                    tem = true;
                }
                catch
                {
                    this.mensagem = "erro com banco de dados";
                }
                
            }
            else
            {
                this.mensagem = "senhas não correspondem";
            }
            return mensagem;
        }
    }
}
