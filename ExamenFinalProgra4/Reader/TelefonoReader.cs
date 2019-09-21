using ExamenFinalProgra4.Mapper;
using Modelos.TelefonoModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalProgra4.Reader
{
    public class TelefonoReader : ObjetReaderWithConnection<TelefonoModel>
    {

        private string DefaultCommad = "SELECT * FROM TelefonoTBL";

        public TelefonoReader(DataClass.QueryRepo.TipoQuery tipo, TelefonoModel telefonoModel)
        {
            switch (tipo)
            {
                case TipoQuery.Todos:
                    this.DefaultCommad = QueryProcessor.QueryAll(QueryRepo.SelectAll, "TelefonoTBL");
                    break;
                case TipoQuery.PorId:
                    this.DefaultCommad = QueryProcessor.QueryByID(QueryRepo.SelectByID, "TelefonoTBL", "Id_Telefono", telefonoModel.Id_Telefono.ToString());
                    break;
                case TipoQuery.TodosConFiltros:
                    this.DefaultCommad = QueryProcessor.QueryAll(QueryRepo.SelectAll, "TelefonoTBL", telefonoModel);
                    break;
                case TipoQuery.PorIdConFiltro:
                    break;
                case TipoQuery.AddRow:
                    this.DefaultCommad = QueryProcessor.AddRow(QueryRepo.AddRow, "TelefonoTBL", telefonoModel);
                    break;
                case TipoQuery.UpdateRow:
                    this.DefaultCommad = QueryProcessor.UpdateRow(QueryRepo.UpdateRow, "TelefonoTBL", telefonoModel);
                    break;
                default:
                    break;
            }
        }


        protected override string CommandText => DefaultCommad;

        protected override CommandType CommandType => CommandType.Text;

        protected override Mapper.MapperBase<TelefonoModel> GetMapper()
        {
            MapperBase<TelefonoModel> mapper = new TelefonoMapper();
            return mapper;
        }

        protected override Collection<IDataParameter> GetParameters(IDbCommand commnad)
        {
            Collection<IDataParameter> collection = new Collection<IDataParameter>();
            return collection;
        }
    }
}
