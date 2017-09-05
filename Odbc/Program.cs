using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odbc.DAO;
using Odbc.Model;

namespace Odbc
{
    class Program
    {
        static void Main(String[] args)
        {
            DAOGeral daozona;

            daozona = new DAOLivro("SQL SERVER", "NETI-PC", "livraria", "sa", "12345678");
            bool par = daozona.insere<Livro>(new Model.Livro());
            Console.WriteLine(par);
            Console.ReadKey();
        }
    }
}
