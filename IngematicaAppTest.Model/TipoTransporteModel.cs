using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngematicaAppTest.Model
{
    public partial class TipoTransporteModel
    {
        public int IdTipoTransporte  {get; set;}

        public string Nombre { get; set; }
        
        public decimal CoeficineteDemora { get; set; }

    }
}
