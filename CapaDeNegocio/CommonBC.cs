using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;

namespace CapaDeNegocio
{
    public class CommonBC
    {
        private static ventas001DEntities _modeloVentas;
        public static ventas001DEntities ModeloVentas
        {
            get
            {
                if (_modeloVentas == null)
                    _modeloVentas = new ventas001DEntities();
                return _modeloVentas;
            }
        }
    }
}