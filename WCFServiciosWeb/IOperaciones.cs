using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiciosWeb
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IOperaciones
    {
        [OperationContract]
        string Sumar(int nro1, int nro2);
        [OperationContract]
        string Restar(int nro1, int nro2);
        [OperationContract]
        string Multiplicar(float nro1, float nro2);
        [OperationContract]
        string Dividir(float nro1, float nro2);

    }

    
}
