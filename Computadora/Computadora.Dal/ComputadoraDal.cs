using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Computadora.Modelos;
using System.Data;

namespace Computadora.Dal
{
    public class ComputadoraDal
    {
        public DataTable ListarComputadoraDal()
        {
            string consulta = "select * from computadora";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarComputadoraDal(Computadora computadora )
        {
            string consulta = "insert into persona values('"+computadora.id+ "'," +
                                                         "'"+computadora.nombre+ "'," +
                                                         "'" +computadora.
    }
}
