using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiciosWeb
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Operaciones : IOperaciones
    {
        public string Sumar(int nro1, int nro2)
        {
            int resultado = nro1 + nro2;
            return "el resultado es :" + resultado;
        }

        public string Restar(int nro1, int nro2)
        {
            int resultado = nro1 - nro2;
            return "el resultado es: " + resultado;
        }

        public string Multiplicar(float nro1, float nro2)
        {
            float resultado = nro1 * nro2;
            return "el resultado es: " + resultado;
        }

        public string Dividir(float nro1, float nro2)
        {
            if (nro2 == 0)
                return "No se puede divir con 0";
            float resultado = nro1 / nro2;
            return "el resultado es: " + resultado;
        }

        //Crear proyecto jframe y llamada al servicio
        //formulario solicitando 2 numeros
    }
}
