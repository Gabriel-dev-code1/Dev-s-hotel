using PIM_Hotel.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_Hotel.Modelo
{
    class Controle
    {
        public bool tem;
        public string mensagem = "";
        public bool acessar(String login, string senha)
        {
            LoginDaoComandos LoginDao = new LoginDaoComandos();
            tem=LoginDao.verificarLogin(login, senha);
            if (LoginDao.mensagem.Equals(""))
            {
                this.mensagem = LoginDao.mensagem;
            }
            return tem;
        }
        public string cadastrar(string email, string senha, string confirmSenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem=loginDao.cadastrar(email, senha, confirmSenha);
            if (loginDao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }

    }
}

