
using DataAcess.Crud;
using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreAPI
{
    public class ConsultaManager : BaseManager
    {
        private ConsultaCrudFactory crudConsulta;

        public ConsultaManager()
        {
            crudConsulta = new ConsultaCrudFactory();
        }

        public void Create(Consulta Consulta)
        {

                var c = crudConsulta.Retrieve<Consulta>(Consulta);
                crudConsulta.Create(Consulta);

        }

        public List<Consulta> RetrieveAll()
        {
            return crudConsulta.RetrieveAll<Consulta>();
        }

        public Consulta RetrieveById(Consulta Consulta)
        {
            Consulta c=null;
                c = crudConsulta.Retrieve<Consulta>(Consulta);
            return c;
        }

        internal void Update(Consulta Consulta)
        {
            crudConsulta.Update(Consulta);
        }

        internal void Delete(Consulta Consulta)
        {
            crudConsulta.Delete(Consulta);
        }
    }
}
