using DataAcess.Crud;
using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class ConsultaManager
    {
        private ConsultaCrudFactory crudConsulta;

        public ConsultaManager()
        {
            crudConsulta = new ConsultaCrudFactory();
        }

        public void Create(Consulta Consulta)
        {
            crudConsulta.Create(Consulta);
        }

        public List<Consulta> RetrieveAll()
        {
            return crudConsulta.RetrieveAll<Consulta>();
        }

        public Consulta RetrieveById(Consulta Consulta)
        {
            return crudConsulta.Retrieve<Consulta>(Consulta);
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
