using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Odbc.DAO
{
    abstract class DAOGeral
    {
        private string conexaoString;
        private OdbcConnection conn;

        public DAOGeral(string driver, string server, string database, string uid, string pwd)
        {
            conexaoString = @"driver={" + driver + "};server=" + server + ";database=" + database + ";uid=" + uid + ";pwd=" + pwd;
            conn = new OdbcConnection(conexaoString); 
        }

        public abstract bool insere<T>(T classe);

        public abstract T pesquisa<T>(long? id);
    }
}
