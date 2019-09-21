using Modelos.TelefonoModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalProgra4.Mapper
{
    class TelefonoMapper : MapperBase<TelefonoModel>

    {
        protected override TelefonoModel Map(IDataRecord registro)
        {
            try
            { 
                TelefonoModel telefono = new TelefonoModel

                {
                    Id_Telefono = registro["Id_Telefono"] == DBNull.Value ? 0 : (int)registro["Id_Telefono"],
                    Gama_Telefono = registro["Gama_Telefono"] == DBNull.Value ? string.Empty : (string)registro["Gama_Telefono"],
                    Lugar_Ensamblaje = registro["Lugar_Ensamblaje"] == DBNull.Value ? string.Empty : (string)registro["Lugar_Ensamblaje"],
                    Precio_Telefono = registro["Precio_Telefono"] == DBNull.Value ? string.Empty : (string)registro["Precio_Telefono"],
                    Precio_Ensamblaje = registro["Precio_Ensamblaje"] == DBNull.Value ? string.Empty : (string)registro["Precio_Ensamblaje"],
                    Color_Telefono = registro["Color_Telefono"] == DBNull.Value ? string.Empty : (string)registro["Color_Telefono"],
                    Usuario = registro["Usuario"] == DBNull.Value ? string.Empty : (string)registro["Usuario"],
                  
                };
                return telefono;


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
