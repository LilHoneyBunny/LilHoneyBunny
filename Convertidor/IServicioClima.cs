using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Convertidor
{
    [ServiceContract]
    public interface IServicioClima
    {
        [OperationContract]
        double convertirCentigradosAFahrenheit(double centigrados);
        [OperationContract]
        double convertirFahrenheitACentigrados(double fahrenheit);
    }
}
