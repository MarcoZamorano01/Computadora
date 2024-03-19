using COMPUTADORA.DAL;
using COMPUTADORA.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPUTADORA.BSS
{
    public class CompuBss
    {
        CompuDal dal = new CompuDal();
        public DataTable ListaComputadoraBss()
        {
            return dal.ListaComputadoraDal();
        }
        public void InsertarComputadoraBss(Computadora compu)
        {
            dal.InsertarComputadoraDal(compu);
        }
        public Computadora ObtenerIdBss(int id)
        {
            return dal.ObtenerComputadoraId(id);
        }
        public void EditarComputadoraBss(Computadora com)
        {
            dal.EditarComputadoraDal(com);
        }
        public void EliminarComputadoraBss(int id)
        {
            dal.EliminarComputadoraDal(id);
        }
    }
}
