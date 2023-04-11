using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IngematicaAppTest.Model;
using IngematicaAppTest.Business;

namespace IngematicaAppTest.Service
{
    public partial class LocalidadService
    {

        public List<LocalidadModel> GetList()
        {
            LocalidadBusiness bs = new LocalidadBusiness();

            return bs.GetList();
        }

        public LocalidadModel GetById(int id)
        {
            LocalidadBusiness bs = new LocalidadBusiness();

            LocalidadModel localidad = bs.GetById(id);

            return localidad;
        }
    }
}
