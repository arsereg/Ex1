using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class Consulta : BaseEntity
    {
        public int Id_Consulta { get; set; }
        public int Id_traduccion { get; set; }
        public string Nombre_usuario { get; set; }

        public Consulta()
        {
            
        }
    }
}
