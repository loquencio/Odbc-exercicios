using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Odbc
{
    class RemoveEditora
    {
        static void Main(string[] args)
        {
            using (OdbcConnection conn = ConnectionFactory.CreateConnection())
            {
                Console.WriteLine("Insira o id:");
                long? id = Convert.ToInt64(Console.ReadLine());

                string sql = @"DELETE FROM dbo.Editora WHERE id = ?";

                OdbcCommand cmd = new OdbcCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();

                cmd.ExecuteNonQuery();
            }
        }
    }
}
