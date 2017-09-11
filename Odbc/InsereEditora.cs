//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.Odbc;
//using Odbc.Model;

//namespace Odbc
//{
//    class InsereEditora
//    {
//        static void Main(String[] args)
//        {
//            //string conexaoString = @"driver={SQL SERVER};server=NETI-PC;database=livraria;uid=sa;pwd=12345678";

//            Editora e = new Editora();

//            Console.WriteLine("Insira o nome da Editora:");
//            e.Nome = Console.ReadLine();

//            Console.WriteLine("Insira o email da Editora:");
//            e.Email = Console.ReadLine();


//            string sql =
//                @"INSERT INTO Editora (Nome, Email)
//                OUTPUT INSERTED.id
//                VALUES(?, ?)";

//            using (OdbcConnection conn = ConnectionFactory.CreateConnection())
//            {
//                conn.Open();
//                OdbcCommand cmd = new OdbcCommand(sql, conn);
//                cmd.Parameters.AddWithValue("@Nome", e.Nome);
//                cmd.Parameters.AddWithValue("@Email", e.Email);
//                e.Id = cmd.ExecuteScalar() as long?;

//                Console.WriteLine("Editora cadastrada com id: " + e.Id);
//            }
//        }
//    }
//}
