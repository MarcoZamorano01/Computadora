using SISTEMASVENTAS.DAL;
using System;
using COMPUTADORA.MODELOS;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPUTADORA.DAL
{
    public class CompuDal
    {
        public DataTable ListaComputadoraDal()
        {
            string cosulta = "select * from computadora";
            DataTable Lista = conexion.EjecutarDataTabla(cosulta, "tabla");
            return Lista;
        }

        public void InsertarComputadoraDal(Computadora compu)
        {
            string consulta = "insert into computadora values('" + compu.Nombre + "'," + "'" + compu.Descripcion + "'," + "'" + compu.Precio + "'," + "'" + compu.FechaFabric + "')";
            conexion.Ejecutar(consulta);
        }

        public Computadora ObtenerComputadoraId(int Id)
        {
            string consulta = "select * from computadora where id=" + Id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Computadora com = new Computadora();
            if (tabla.Rows.Count > 0)
            {
                com.Id = Convert.ToInt32(tabla.Rows[0]["Id"]);
                com.Nombre = tabla.Rows[0]["nombre"].ToString();
                com.Descripcion = tabla.Rows[0]["descripcion"].ToString();
                com.Precio = Convert.ToDecimal(tabla.Rows[0]["precio"].ToString());
                com.FechaFabric = Convert.ToDateTime(tabla.Rows[0]["fechafabric"].ToString());
            }
            return com;
        }
        public void EditarComputadoraDal(Computadora com)
        {
            string consulta = "update computadora set nombre='" + com.Nombre + "'," + "descripcion='" + com.Descripcion + "'," + "precio='" + com.Precio + "'," + "fechafabric='" + com.FechaFabric + "' " + "where id=" + com.Id;
            conexion.Ejecutar(consulta);
        }
        public void EliminarComputadoraDal(int id)
        {
            string consulta = "delete from computadora where id=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
