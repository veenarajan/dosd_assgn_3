using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SolarEnergyService
{
    // my service interface
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        decimal GetSolarIntensity(decimal latitude, decimal longitude);
    }
}
