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
            if (codigo == 0 || codigo < 0)
            {
                throw new ArgumentException("El código no puede ser cero o negativo.");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(sala))
                {
                    throw new ArgumentException("La sala no puede estar vacía.");
                } 
            }

            objCd.RegistrarFuncion(codigo, fechaHora, sala);
        }


        public DataTable ListarF()
        {
            return objCd.ListarFunciones();
            
        }

        public DataTable BuscarF (int codigo) 
        {
          return objCd.BuscarFuncion(codigo);
        }


    }
}
