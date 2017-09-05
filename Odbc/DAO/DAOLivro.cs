using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odbc.DAO
{
    class DAOLivro : DAOGeral
    {
        public DAOLivro(string drive, string server, string database, string uid, string pwd) : base(drive, server, database, uid, pwd)
        {
           
        }
        public override bool insere<T>(T classe)
        {
            Console.WriteLine("TESTEEEEEE");
            Console.WriteLine(classe.GetType());
            return true;
        }

        public override T pesquisa<T>(long? id)
        {
            throw new NotImplementedException();
        }
    }
}
