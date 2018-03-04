using System;
using System.Collections.Generic;
using Entities_POJO;
using DataAcess.Mapper;
using DataAcess.Dao;

namespace DataAcess.Crud
{
    public class ConsultaCrudFactory : CrudFactory
    {
        ConsultaMapper mapper;

        public ConsultaCrudFactory() : base()
        {
            mapper = new ConsultaMapper();
            dao = SqlDao.GetInstance();
        }

        public override void Create(BaseEntity entity)
        {
                var Consulta = (Consulta)entity;
                var sqlOperation = mapper.GetCreateStatement(Consulta);

                dao.ExecuteProcedure(sqlOperation);
        }

        public override T Retrieve<T>(BaseEntity entity)
        {
            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetriveStatement(entity));
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                dic = lstResult[0];
                var objs = mapper.BuildObject(dic);
                return (T)Convert.ChangeType(objs, typeof(T));
            }

            return default(T);
        }

        public override List<T> RetrieveAll<T>()
        {
            var lstConsultas = new List<T>();
            
            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetriveAllStatement());
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                var objs = mapper.BuildObjects(lstResult);
                foreach (var c in objs)
                {
                    lstConsultas.Add((T)Convert.ChangeType(c, typeof(T)));
                }
            }
           
            return lstConsultas;
        }

        public override void Update(BaseEntity entity)
        {
            var Consulta = (Consulta)entity;
            dao.ExecuteProcedure(mapper.GetUpdateStatement(Consulta));
        }

        public override void Delete(BaseEntity entity)
        {
            var Consulta = (Consulta)entity;
            dao.ExecuteProcedure(mapper.GetDeleteStatement(Consulta));
        }
    }
}
