using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IngematicaAppTest.Model;
using IngematicaAppTest.Business;

namespace IngematicaAppTest.Service
{
    public partial class TipoTransporteService
    {
        public List<TipoTransporteModel> GetList()
        {
            TipoTransporteBusiness bs = new TipoTransporteBusiness();

            return bs.GetList();
        }

        public TipoTransporteModel GetById(int id)
        {
            TipoTransporteBusiness bs = new TipoTransporteBusiness();

            TipoTransporteModel tipoTransporte = bs.GetById(id);

            return tipoTransporte;
        }
    }
}
