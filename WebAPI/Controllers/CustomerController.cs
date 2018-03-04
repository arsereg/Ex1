using CoreAPI;
using Entities_POJO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    [ExceptionFilter]
    public class ConsultaController : ApiController
    {
        
        // GET api/Consulta
        public IHttpActionResult Get()
        {

            var mng = new ConsultaManager();
            var lstConsultas = mng.RetrieveAll();   
            return Ok(lstConsultas);
        }

        // GET api/Consulta/5
        public IHttpActionResult Get(int id)
        {
                var mng = new ConsultaManager();
                var Consulta = new Consulta
                {
                    Id_Consulta = id
                };

                Consulta = mng.RetrieveById(Consulta);
                return Ok(Consulta);
 
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
