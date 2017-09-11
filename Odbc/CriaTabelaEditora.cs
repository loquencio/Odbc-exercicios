//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.Odbc;

//namespace Odbc
//{
//    class CriaTabelaEditora
//    {
//        static void Main(string[] args)
//        {
//           // string conexaoString = @"driver={SQL SERVER};server=NETI-PC;database=livraria;uid=sa;pwd=12345678";

//            using (OdbcConnection conn = ConnectionFactory.CreateConnection())
//            {
//                conn.Open();

//                string sql =
//                    "CREATE TABLE Editora (" +
//                        "id BIGINT IDENTITY(1,1)," +
//                        "nome VARCHAR(255) NOT NULL," +
//                        "email VARCHAR(255) NOT NULL," +
//                        "CONSTRAINT PK_Editora PRIMARY KEY CLUSTERED (id asc)" +
//                    ")";
//                OdbcCommand cmd = new OdbcCommand(sql, conn);
//                cmd.ExecuteNonQuery();
//            }
//        }
//    }
//}
