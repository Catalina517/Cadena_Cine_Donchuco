using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio
{
    public class CN_Funcion
    {
        private CD_Funcion objCd= new CD_Funcion();




        public void RegistarF(int codigo, DateTime fechaHora, string sala) 
        {
          objCd.RegistrarFuncion(codigo, fechaHora, sala);
        }


        public DataTable ListarF()
        {
            return objCd.ListarFunciones();
            
        }

        public DataRow BuscarF (int codigo) 
        {
          return objCd.BuscarFuncion(codigo);
        }


    }
}
