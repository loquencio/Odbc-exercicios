using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odbc.Model;

namespace Odbc.DAO
{
    class DAOLivro : DAOGeral
    {
        public DAOLivro(string drive, string server, string database, string uid, string pwd) : base(drive, server, database, uid, pwd)
        {
            if (!verificaExistencia())
            {

            }

        }
        public override bool insere<Livro>(Livro livro)
        {
            using (conn = new System.Data.Odbc.OdbcConnection(conexaoString))
            {
                
            }

            return true;
        }

        public override T pesquisa<T>(long? id)
        {
            throw new NotImplementedException();
        }
        
        public bool verificaExistencia()
        {
            //a-fazer
            return false;
        }
    }
}
