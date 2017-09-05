using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Odbc
{
    class CriaDatabaseLivraria
    {
        //static void Main(String[] args)
        //{
        //    string ConexaoString = "driver={SQL Server};server=NETI-PC;uid=sa;pwd=12345678";

        //    using (OdbcConnection Conexao = new OdbcConnection(ConexaoString))
        //    {
        //        String Sql;
        //        OdbcCommand Cmd;

        //        Conexao.Open();
        //        Sql = @"IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = 'livraria') DROP DATABASE livraria";
        //        Cmd = new OdbcCommand(Sql, Conexao);
        //        Cmd.ExecuteNonQuery();

        //        Sql = @"CREATE DATABASE livraria";
        //        Cmd = new OdbcCommand(Sql, Conexao);
        //        Cmd.ExecuteNonQuery();
        //    }
        //}
    }
}
