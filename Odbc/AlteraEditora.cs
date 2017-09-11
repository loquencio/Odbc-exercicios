//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Odbc.Model;
//using System.Data.Odbc;

//namespace Odbc
//{
//    class AlteraEditora
//    {
//        static void Main(string[] args)
//        {
//            using (OdbcConnection conn = ConnectionFactory.CreateConnection())
//            {
//                Editora e = new Editora();

//                Console.WriteLine("Insira o id: ");
//                e.Id = Convert.ToInt64(Console.ReadLine());

//                Console.WriteLine("Insira o novo nome: ");
//                e.Nome = Console.ReadLine();

//                Console.WriteLine("Insira o novo email: ");
//                e.Email = Console.ReadLine();

//                string sql = @"UPDATE dbo.Editora SET nome = ?, email = ? WHERE id = ?";

//                OdbcCommand cmd = new OdbcCommand(sql, conn);

//                cmd.Parameters.AddWithValue("@Nome", e.Nome);
//                cmd.Parameters.AddWithValue("@Email", e.Email);
//                cmd.Parameters.AddWithValue("@id", e.Id);

//                conn.Open();

//                cmd.ExecuteNonQuery();
//            }
//        }
//    }
//}
