using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocio
{
    class Marca
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public Boolean Activo { get; set; }

        public int Create()
        {
            try
            {
                CapaDeDatos.Marca m = new CapaDeDatos.Marca();
                m.nombre = Nombre;
                m.activo = Activo ? 1 : 0;
                CommonBC.ModeloVentas.Marca.Add(m);
                return CommonBC.ModeloVentas.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }
        public int Read()
        {
            try
            {
                CapaDeDatos.Marca m = CommonBC.ModeloVentas.Marca.
                                                First(x => x.idMarca == Id);
                Nombre = m.nombre;
                Activo = m.activo == 1 ? true : false;

                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public int Update()
        {
            try
            {
                CapaDeDatos.Marca m = CommonBC.ModeloVentas.Marca.
                                                First(x => x.idMarca == Id);
                m.nombre = Nombre;
                m.activo = Activo ? 1 : 0; // operador ternario

                return CommonBC.ModeloVentas.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1; // negativo error
            }
        }

        public int Delete()
        {
            try
            {
                CapaDeDatos.Marca m = CommonBC.ModeloVentas.Marca.
                                                First(x => x.idMarca == Id);
                CommonBC.ModeloVentas.Marca.Remove(m);
                return CommonBC.ModeloVentas.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1; // negativo error
            }
        }


    }
}
