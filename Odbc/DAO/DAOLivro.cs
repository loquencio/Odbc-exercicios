using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odbc.Model;
using System.Data.Odbc;

namespace Odbc.DAO
{
    class DAOLivro : DAOGeral
    {
        public DAOLivro(string drive, string server, string database, string uid, string pwd) : base(drive, server, database, uid, pwd)
        {
            
        }
        public override bool insere<Livro>(Livro livro)
        {
            Console.WriteLine();

            using (conn = new System.Data.Odbc.OdbcConnection(conexaoString))
            {
            }

            return true;
        }

        public override Livro pesquisa<Livro>(long? id)
        {
            Console.WriteLine(id);
            throw new NotImplementedException();
        }
    
    }
}
