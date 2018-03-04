using DataAcess.Dao;
using Entities_POJO;
using System.Collections.Generic;

namespace DataAcess.Mapper
{
    public class ConsultaMapper : EntityMapper, ISqlStaments, IObjectMapper
    {
        private const string DB_COL_ID_CONSULTA = "id_consulta";
        private const string DB_COL_ID_TRADUCCION = "id_traduccion";
        private const string DB_COL_NAME= "nombre_usuario";


        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation {ProcedureName = "PA_REGISTRAR_CONSULTA"};

            var c = (Consulta) entity;            
            operation.AddIntParam(DB_COL_ID_CONSULTA, c.Id_Consulta);
            operation.AddIntParam(DB_COL_ID_TRADUCCION, c.Id_traduccion);
            operation.AddVarcharParam(DB_COL_NAME, c.Nombre_usuario);

            return operation;
        }


        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public SqlOperation GetRetriveAllStatement()
        {
            throw new System.NotImplementedException();
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var customer = BuildObject(row);
                lstResults.Add(customer);
            }

            return lstResults;            
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var customer = new Consulta
            {
                Id_Consulta = GetIntValue(row, DB_COL_ID_CONSULTA),
                Id_traduccion = GetIntValue(row, DB_COL_ID_TRADUCCION),
                Nombre_usuario = GetStringValue(row, DB_COL_NAME)
                
            };

            return customer;
        }       

    }
}
