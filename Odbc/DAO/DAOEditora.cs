using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using Odbc.Model;

namespace Odbc.DAO
{
    class DAOEditora : DAOGeral
    {
        public DAOEditora(string driver, string server, string database, string uid, string pwd) : base(driver, server, database, uid, pwd)
        {

        }

        public override bool insere<Editora>(Editora editora)
        {
            throw new NotImplementedException();
        }

        public override T pesquisa<T>(long? id)
        {
            throw new NotImplementedException();
        }
    }
}
