using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odbc
{
    class ConnectionFactory
    {
        public static OdbcConnection CreateConnection()
        {
            string driver = @"SQL Server";
            string servidor = @"NETI-PC";
            string db = "livraria";
            string uid = "sa";
            string pwd = "12345678";

            StringBuilder conexaoString = new StringBuilder();
            conexaoString.Append("driver=");
            conexaoString.Append(driver);
            conexaoString.Append(";server=");
            conexaoString.Append(servidor);
            conexaoString.Append(";database=");
            conexaoString.Append(db);
            conexaoString.Append(";uid=");
            conexaoString.Append(uid);
            conexaoString.Append(";pwd=");
            conexaoString.Append(pwd);

            return new OdbcConnection(conexaoString.ToString());
        }
    }
}
