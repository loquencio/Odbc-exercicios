using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Odbc
{
    class Program
    {
        static void Main(String[] args)
        {
            string ConexaoString = "driver={SQL Server};server=NETI-PC;uid=sa;pwd=12345678";

            using (OdbcConnection Conexao = new OdbcConnection(ConexaoString))
            {
                Conexao.Open();
                string Sql = @"IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = 'livraria') DROP DATABASE livraria";
                OdbcCommand Cmd = new OdbcCommand(Sql, Conexao);
                Cmd.ExecuteNonQuery();
            }
        }
    }
}
