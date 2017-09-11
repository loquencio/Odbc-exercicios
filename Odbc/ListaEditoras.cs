//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.Odbc;

//namespace Odbc
//{
//    class ListaEditoras
//    {
//        static void Main(String[] args)
//        {
//            string nome;
//            string email;
//            long? id;

//            //string conexaoString = @"driver={SQL SERVER};server=NETI-PC;database=livraria;uid=sa;pwd=12345678";
//            string sql = @"SELECT * FROM dbo.Editora";

//            using (OdbcConnection conn = ConnectionFactory.CreateConnection()) 
//            {
//                conn.Open();
//                OdbcCommand cmd = new OdbcCommand(sql, conn);
//                OdbcDataReader reader =  cmd.ExecuteReader();
//                while (reader.Read())
//                {
//                    id = reader["id"] as long?;
//                    nome = reader["nome"] as string;
//                    email = reader["email"] as string;

//                    Console.WriteLine("Id: " + id + "\nNome: " + nome + "\nE-mail: " + email);
//                }

//                Console.ReadLine();
//            }

            
//        }
//    }
//}
