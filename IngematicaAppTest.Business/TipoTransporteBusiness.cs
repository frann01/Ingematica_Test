using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IngematicaAppTest.Model;

namespace IngematicaAppTest.Business
{
    public partial class TipoTransporteBusiness
    {

        public List<TipoTransporteModel> GetList()
        {
            List<TipoTransporteModel> lista = SetList();

            return lista;
        }

        public TipoTransporteModel GetById(int id)
        {
            List<TipoTransporteModel> lista = SetList();

            TipoTransporteModel tipoTransporte = lista.Where(x => x.IdTipoTransporte == id).FirstOrDefault();
            
            return tipoTransporte;
        }

        private static List<TipoTransporteModel> SetList()
        {
            List<TipoTransporteModel> lista = new List<TipoTransporteModel>();

            lista.Add(new TipoTransporteModel { IdTipoTransporte = 1, Nombre = "F-100", CoeficineteDemora = 1 });
            lista.Add(new TipoTransporteModel { IdTipoTransporte = 2, Nombre = "F-350", CoeficineteDemora = 1 });
            lista.Add(new TipoTransporteModel { IdTipoTransporte = 3, Nombre = "F-7000", CoeficineteDemora = 1 });
            lista.Add(new TipoTransporteModel { IdTipoTransporte = 4, Nombre = "CAMION CON PALA", CoeficineteDemora = (decimal)1.2 });
            lista.Add(new TipoTransporteModel { IdTipoTransporte = 5, Nombre = "EQUIPO COMPLETO", CoeficineteDemora = (decimal)1.3 });
            lista.Add(new TipoTransporteModel { IdTipoTransporte = 6, Nombre = "TRAFIC", CoeficineteDemora = 1 });
            lista.Add(new TipoTransporteModel { IdTipoTransporte = 7, Nombre = "TRACTOR", CoeficineteDemora = (decimal)1.5 });
            return lista;
        }
    }
}
