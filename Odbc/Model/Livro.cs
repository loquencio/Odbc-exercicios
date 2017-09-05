using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odbc.Model
{
    class Livro
    {
        public long? Id { get; set; }
        public string Titulo { get; set; }
        public long? EditoraId { get; set; }
    }
}
