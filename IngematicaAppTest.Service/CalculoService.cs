using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IngematicaAppTest.Model;

namespace IngematicaAppTest.Service
{
    public partial class CalculoService
    {
        public static ResultadoModel Calcular(LocalidadModel destino,TipoTransporteModel tipoTransporte,string tipoRuta,DateTime fechaSalida) 
        {
            decimal cantidadDias = destino.DiasDemora * tipoTransporte.CoeficineteDemora;

            if(tipoRuta == "Ruta") {
                cantidadDias += cantidadDias * (decimal)0.1;
            }

            int diasRedondeado = (int)Math.Ceiling(cantidadDias);
            int diasDemora = diasRedondeado;

            while (diasRedondeado > 0)
            {
                fechaSalida = fechaSalida.AddDays(1);
                if (fechaSalida.DayOfWeek != DayOfWeek.Sunday && fechaSalida.DayOfWeek != DayOfWeek.Saturday) 
                {
                    diasRedondeado--;
                }
            }
            ResultadoModel resultado = new ResultadoModel { diasDemora = diasDemora, fechaLlegada = fechaSalida};
            return resultado;
        }
    }
}
