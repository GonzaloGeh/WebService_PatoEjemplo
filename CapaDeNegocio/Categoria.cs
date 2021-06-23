using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocio
{
    class Categoria
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public Boolean Activo { get; set; }

        public int Create()
        {
            try
            {
                CapaDeDatos.Categoria c = new CapaDeDatos.Categoria();
                c.nombre = Nombre;
                c.activo = Activo ? 1 : 0;
                CommonBC.ModeloVentas.Categoria.Add(c);
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
                CapaDeDatos.Categoria c = CommonBC.ModeloVentas.Categoria.
                                                First(x => x.idCategoria == Id);
                Nombre = c.nombre;
                Activo = c.activo == 1 ? true : false;

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
                CapaDeDatos.Categoria c = CommonBC.ModeloVentas.Categoria.
                                                First(x => x.idCategoria == Id);
                c.nombre = Nombre;
                c.activo = Activo ? 1 : 0; // operador ternario

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
                CapaDeDatos.Categoria c = CommonBC.ModeloVentas.Categoria.
                                                First(x => x.idCategoria == Id);
                CommonBC.ModeloVentas.Categoria.Remove(c);
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
