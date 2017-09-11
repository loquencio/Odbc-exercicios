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
        protected string conexaoString;
        protected OdbcConnection conn;

        public DAOGeral(string driver, string server, string database, string uid, string pwd)
        {
           // conexaoString = @"driver={" + driver + "};server=" + server + ";database=" + database + ";uid=" + uid + ";pwd=" + pwd;
            conexaoString = @"driver={" + driver + "};server=" + server + ";uid=" + uid + ";pwd=" + pwd;
            criaDbLivraria();
         //   conn = new OdbcConnection(conexaoString); 
        }

        public abstract bool insere<T>(T classe);

        public abstract T pesquisa<T>(long? id);

        public void criaDbLivraria()
        {
            string sql = @"IF NOT EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = 'livraria') CREATE DATABASE livraria;";

            using (conn = new OdbcConnection(conexaoString))
            {
                conn.Open();
                OdbcCommand cmd = new OdbcCommand(sql, conn);
                cmd.ExecuteNonQuery();
                criaTabelaEditora(conn);
                criaTabelaLivro(conn);   
            }

          
        }

        public void criaTabelaLivro(OdbcConnection conn)
        {
            string sql = @"IF NOT EXISTS(SELECT name FROM livraria.sys.tables WHERE UPPER(name) = 'LIVRO') BEGIN CREATE TABLE livraria.dbo.Livro ( id BIGINT IDENTITY(1,1), titulo VARCHAR(255) NOT NULL, autor VARCHAR(255) NOT NULL, editoraId BIGINT NOT NULL, CONSTRAINT Pk_Livro PRIMARY KEY CLUSTERED(id asc)) ALTER TABLE livraria.dbo.Livro ADD CONSTRAINT FK_livro_editora FOREIGN KEY(editoraId) REFERENCES livraria.dbo.Editora (id) END;";

            OdbcCommand cmd = new OdbcCommand(sql, conn);
            cmd.ExecuteNonQuery();
            
        }

        public void criaTabelaEditora(OdbcConnection conn)
        {
            string sql = @"IF NOT EXISTS(SELECT name FROM livraria.sys.tables WHERE UPPER(name) = 'EDITORA') CREATE TABLE livraria.dbo.Editora ( id BIGINT IDENTITY(1,1), nome VARCHAR(255) NOT NULL, email VARCHAR(255) NOT NULL, CONSTRAINT Pk_Editora PRIMARY KEY CLUSTERED(id asc));";

            OdbcCommand cmd = new OdbcCommand(sql, conn);
            cmd.ExecuteNonQuery();
            
        }
    }
}
